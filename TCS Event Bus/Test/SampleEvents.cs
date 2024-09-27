namespace TCS.EventBus.Tests {
    public struct TestEvent : IEvent {
        // No data, used for basic testing
    }

    public struct PlayerEvent : IEvent {
        public int Health;
        public int Mana;

        public PlayerEvent(int health, int mana) {
            Health = health;
            Mana = mana;
        }
    }
}