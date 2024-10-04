using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
// ReSharper disable StaticMemberInGenericType

namespace TCS.EventBus {
    public abstract class EventBus<T> where T : IEvent {
        static readonly HashSet<EventBinding<T>> Bindings = new();
        static readonly HashSet<EventBinding<T>> PendingRemovals = new();
        const int CLEANUP_THRESHOLD = 100; // Cleanup after this many events
        static int sEventCount;
        static readonly CancellationTokenSource CancellationTokenSource = new();

        public static void Register(EventBinding<T> binding) => Bindings.Add(binding);
        public static void Deregister(EventBinding<T> binding) => PendingRemovals.Add(binding);

        public static async void Raise(T eventInstance) {
            if (sEventCount >= CLEANUP_THRESHOLD) {
                foreach (EventBinding<T> binding in PendingRemovals) {
                    Bindings.Remove(binding);
                }

                PendingRemovals.Clear();
                sEventCount = 0;
            }

            sEventCount++;

            int numBindings = Bindings.Count;

            if (numBindings < 100) {
                foreach (EventBinding<T> binding in Bindings) {
                    binding.OnEvent?.Invoke(eventInstance);
                    binding.OnEventNoArgs?.Invoke();
                }
            } else {
                const int batchSize = 100;
                List<EventBinding<T>> bindingList = new(Bindings);

                for (var i = 0; i < numBindings; i += batchSize) {
                    await ProcessBatch(bindingList.GetRange(i, Math.Min(batchSize, numBindings - i)), eventInstance, CancellationTokenSource.Token);
                }
            }
        }

        static async Task ProcessBatch(List<EventBinding<T>> batch, T eventInstance, CancellationToken cancellationToken) {
            foreach (EventBinding<T> binding in batch) {
                if (cancellationToken.IsCancellationRequested) {
                    return;
                }
                binding.OnEvent?.Invoke(eventInstance);
                binding.OnEventNoArgs?.Invoke();
            }

            await Task.Yield();
        }

        public static void Clear() {
            Bindings.Clear();
            PendingRemovals.Clear();
        }

        public static void OnApplicationQuit() {
            CancellationTokenSource.Cancel();
            Clear();
        }
    }
}