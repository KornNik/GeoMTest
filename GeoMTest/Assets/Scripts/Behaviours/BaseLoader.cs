using UnityEngine;
using Data;
using Helpers;

namespace Behaviours
{
    abstract class BaseLoader<T> : IObjectLoader where T : MonoBehaviour
    {
        public DataResourcePrefabs DataResourcePrefabs => Services.Instance.DataResourcePrefabs.ServicesObject;
        protected T _loadingObject;

        public void Clear()
        {
            GameObject.Destroy(_loadingObject.gameObject);
            _loadingObject = null;
        }

        public virtual void Load()
        {
            if (_loadingObject != null) { Clear(); }
        }

        public void LoadOnPlace(Vector3 spawnPlace)
        {
            Load();
            _loadingObject.transform.localPosition = spawnPlace;
        }
    }
}
