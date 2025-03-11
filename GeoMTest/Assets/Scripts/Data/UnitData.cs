using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "UnitData", menuName = "Data/Unit/UnitData")]
    sealed class UnitData : ScriptableObject
    {
        [SerializeField] private float _health;
        [SerializeField] private float _damage;
        [SerializeField] private float _speed;
        [SerializeField] private float _interactDistance;

        public float Health => _health;
        public float Damage => _damage;
        public float Speed => _speed;
        public float InteractDistance => _interactDistance;
    }
}
