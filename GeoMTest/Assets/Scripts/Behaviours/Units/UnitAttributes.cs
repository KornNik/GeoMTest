using Data;
using Attributes;
using Helpers;
using UI;
using System.Collections.Generic;

namespace Behaviours
{
    class UnitAttributes: IEventListener<BoostSelectEvent>,IEventListener<AttributesRequestEvent>, IEventSubscription
    {
        public ObjectAttributeFloat Health;
        public ObjectAttributeFloat Damage;
        public ObjectAttributeFloat Speed;
        public float InteractDistance;

        private Dictionary<AttributType, ObjectAttributeFloat> _attributes;

        public UnitAttributes(UnitData _unitData)
        {
            _attributes = new Dictionary<AttributType, ObjectAttributeFloat>(3);
            Health = new ObjectAttributeFloat(new AttributeDataFloat(999,0, _unitData.Health)) ;
            Damage = new ObjectAttributeFloat(new AttributeDataFloat(999, 0, _unitData.Damage));
            Speed = new ObjectAttributeFloat(new AttributeDataFloat(999, 0, _unitData.Speed));
            InteractDistance = _unitData.InteractDistance;

            FillDictionary();
        }

        private void FillDictionary()
        {
            _attributes.Add(AttributType.Health, Health);
            _attributes.Add(AttributType.Damage, Damage);
            _attributes.Add(AttributType.Speed, Speed);
        }
        private void ModifyAttribute(BoosterData data)
        {
            if (_attributes.ContainsKey(data.AttributeType))
            {
                _attributes[data.AttributeType].AddModifier(new StatModifier(data.ModifierValue, data.MoidfierType));
            }
        }

        public void Subscribe()
        {
            this.EventStartListening<BoostSelectEvent>();
            this.EventStartListening<AttributesRequestEvent>();
        }

        public void Unsubscribe()
        {
            this.EventStopListening<BoostSelectEvent>();
            this.EventStopListening<AttributesRequestEvent>();
        }

        public void OnEventTrigger(AttributesRequestEvent eventType)
        {
            AttributesInfoEvent.Trigger(new SendingAttributesInfo
                (Health.CurrentValue, Speed.CurrentValue, Damage.CurrentValue));
        }
        public void OnEventTrigger(BoostSelectEvent eventType)
        {
            ModifyAttribute(eventType.Data);
        }
    }
}
