using Data;

namespace Behaviours
{
    class Attributes
    {
        public float Health;
        public float Damage;
        public float Speed;
        public float InteractDistance;

        public Attributes(UnitData _unitData)
        {
            Health = _unitData.Health;
            Damage = _unitData.Damage;
            Speed = _unitData.Speed;
            InteractDistance = _unitData.InteractDistance;
        }
    }
}
