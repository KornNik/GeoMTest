using UnityEngine;

namespace Behaviours
{
    sealed class Level : MonoBehaviour
    {
        [SerializeField] private Transform _playerSpawn;
        [SerializeField] private Transform _boosterSpawn;

        public Transform PlayerSpawn => _playerSpawn;
        public Transform BoosterSpawn => _boosterSpawn;
    }
}
