using Behaviours;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName ="LevelData",menuName ="Data/Level/LevelData")]
    class LevelData : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private Level _levelPrefab;
        [SerializeField] private Vector3 _levelPosition;

        public Level LevelPrefab => _levelPrefab;
        public Vector3 LevelPosition => _levelPosition;
        public string Name => _name;
    }
}
