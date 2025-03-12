using UnityEngine;
using Data;

namespace Behaviours
{
    interface IObjectLoader
    {
        DataResourcePrefabs DataResourcePrefabs { get; }

        void Load();
        void LoadOnPlace(Vector3 spawnPlace);
        void Clear();
    }
}
