using System.Diagnostics;
using TC.EventBus.TestSystems;
using UnityEngine;
using Debug = UnityEngine.Debug;
namespace TCS.EventBus.Tests {
    public class EventBusBenchmark : MonoBehaviour {
        const int NUM_EVENTS = 1000;

        void Start() {
            // Register handlers for TestEvent
            EventBus<TestEvent>.Register(new EventBinding<TestEvent>(
                                             onEvent: OnTestEvent,
                                             onEventNoArgs: OnTestEventNoArgs
                                         ));

            // Register handlers for PlayerEvent
            EventBus<PlayerEvent>.Register(new EventBinding<PlayerEvent>(
                                               onEvent: OnPlayerEvent,
                                               onEventNoArgs: OnPlayerEventNoArgs
                                           ));

            // Benchmark TestEvent
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < NUM_EVENTS; i++) {
                EventBus<TestEvent>.Raise(new TestEvent());
            }

            stopwatch.Stop();
            Debug.Log($"Time taken to raise {NUM_EVENTS} TestEvent: {stopwatch.ElapsedMilliseconds} ms");

            // Benchmark PlayerEvent
            stopwatch.Reset();
            stopwatch.Start();
            for (var i = 0; i < NUM_EVENTS; i++) {
                EventBus<PlayerEvent>.Raise(new PlayerEvent(100, 50));
            }

            stopwatch.Stop();
            Debug.Log($"Time taken to raise {NUM_EVENTS} PlayerEvent: {stopwatch.ElapsedMilliseconds} ms");

            // Clear all event bindings
            EventBus<TestEvent>.Clear();
            EventBus<PlayerEvent>.Clear();
        }

        void OnTestEvent(TestEvent testEvent) {
            Debug.Log("TestEvent triggered.");
        }

        void OnTestEventNoArgs() {
            Debug.Log("TestEvent triggered with no arguments.");
        }

        void OnPlayerEvent(PlayerEvent playerEvent) {
            Debug.Log($"Player Health: {playerEvent.Health}, Mana: {playerEvent.Mana}");
        }

        void OnPlayerEventNoArgs() {
            Debug.Log("PlayerEvent triggered with no arguments.");
        }
    }
}