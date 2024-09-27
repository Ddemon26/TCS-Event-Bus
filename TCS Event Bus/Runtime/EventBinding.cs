using System;
namespace TCS.EventBus {
    public class EventBinding<T> where T : IEvent {
        public Action<T> OnEvent { get; private set; }
        public Action OnEventNoArgs { get; private set; }

        public EventBinding(Action<T> onEvent, Action onEventNoArgs = null) {
            OnEvent = onEvent;
            OnEventNoArgs = onEventNoArgs ?? (() => { });
        }

        public void Add(Action<T> onEvent) {
            OnEvent += onEvent;
        }

        public void Remove(Action<T> onEvent) {
            OnEvent -= onEvent;
        }

        public void Add(Action onEventNoArgs) {
            OnEventNoArgs += onEventNoArgs;
        }

        public void Remove(Action onEventNoArgs) {
            OnEventNoArgs -= onEventNoArgs;
        }
    }
}