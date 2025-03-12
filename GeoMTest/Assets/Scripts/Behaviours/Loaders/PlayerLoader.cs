using UnityEngine;
using Data;
using Helpers;

namespace Behaviours
{
    sealed class PlayerLoader : BaseLoader<Player>
    {

        public override void Load()
        {
            base.Load();
            var playerPrefab = DataResourcePrefabs.GetPlayerPrefab();
            _loadingObject = GameObject.Instantiate<Player>(playerPrefab, Vector3.zero, Quaternion.identity);
            Services.Instance.Player.SetObject(_loadingObject);
        }
    }
}
