using Attributes;

namespace Behaviours
{
    abstract class BoosterModifier
    {
        protected StatModifier _statModifier;

        public abstract void ModifyStat(ObjectAttributeFloat objectAttribute);
    }
    sealed class HealthBooster : BoosterModifier
    {
        public override void ModifyStat(ObjectAttributeFloat objectAttribute)
        {
            objectAttribute.AddModifier(_statModifier);
        }
    }
}
