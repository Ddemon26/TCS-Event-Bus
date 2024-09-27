using TC.EventBus.TestSystems;
using UnityEngine;
namespace TCS.EventBus.Tests {
    public class EventBusTest : MonoBehaviour {
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

            // Raise TestEvent
            EventBus<TestEvent>.Raise(new TestEvent());

            // Raise PlayerEvent
            EventBus<PlayerEvent>.Raise(new PlayerEvent(100, 50));

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