using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "CamerasInitilaizationData", menuName = "Data/Camera/CamerasInitilaizationData")]
    class CamerasInitilaizationData : ScriptableObject
    {
        [SerializeField] private Vector3 _mainCameraPosition;
        [SerializeField] private Vector3 _mainCameraRotation;

        public Vector3 GetMainCameraPosition()
        {
            return _mainCameraPosition;
        }
        public Vector3 GetMainCameraRotation()
        {
            return _mainCameraRotation;
        }
    }
}
