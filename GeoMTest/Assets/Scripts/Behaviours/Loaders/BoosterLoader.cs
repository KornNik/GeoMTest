using UnityEngine;
using Data;

namespace Behaviours
{
    sealed class BoosterLoader : BaseLoader<BoosterBehaviour>
    {

        public override void Load()
        {
            base.Load();
            var boosterPrefab = DataResourcePrefabs.GetBoosterPrefab();
            _loadingObject = GameObject.Instantiate<BoosterBehaviour>(boosterPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}
