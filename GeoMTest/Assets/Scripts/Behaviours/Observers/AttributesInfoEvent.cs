using Helpers;

namespace Behaviours
{
    struct SendingAttributesInfo
    {
        public float Health;
        public float Speed;
        public float Damage;

        public SendingAttributesInfo(float health, float speed, float damage)
        {
            Health = health;
            Speed = speed;
            Damage = damage;
        }
    }
    struct AttributesInfoEvent
    {
        private SendingAttributesInfo _attributesInfo;
        private static AttributesInfoEvent _attributesInfoEvent;

        public SendingAttributesInfo AttributesInfo => _attributesInfo;

        public static void Trigger(SendingAttributesInfo attributesInfo)
        {
            _attributesInfoEvent._attributesInfo = attributesInfo;
            EventManager.TriggerEvent(_attributesInfoEvent);
        }
    }
    struct AttributesRequestEvent
    {
        private static AttributesRequestEvent _attributesRequestEvent;

        public static void Trigger()
        {
            EventManager.TriggerEvent(_attributesRequestEvent);
        }
    }
}
