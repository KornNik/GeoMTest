using Attributes;
using UnityEngine;

namespace Data
{
    enum AttributType
    {
        None,
        Health,
        Damage,
        Speed,
    }
    [CreateAssetMenu(fileName = "NewBooster", menuName = "Data/Booster")]
    sealed class BoosterData : ScriptableObject
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private string _description;
        [SerializeField] private string _title;
        [SerializeField] private float _modifierValue;
        [SerializeField] private StatModType _moidfierType;
        [SerializeField] private AttributType _attributeType;

        public Sprite Sprite => _sprite;
        public string Description => _description;
        public string Title => _title;
        public float ModifierValue => _modifierValue;
        public StatModType MoidfierType => _moidfierType;
        public AttributType AttributeType => _attributeType;
    }
}
