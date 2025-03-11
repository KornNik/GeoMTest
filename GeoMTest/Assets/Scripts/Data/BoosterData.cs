using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "NewBooster", menuName = "Data/Booster")]
    sealed class BoosterData : ScriptableObject
    {
        [SerializeField] private Sprite _sprite;
        [SerializeField] private string _description;
        [SerializeField] private string _title;

        public Sprite Sprite => _sprite;
        public string Description => _description;
        public string Title => _title;
    }
}
