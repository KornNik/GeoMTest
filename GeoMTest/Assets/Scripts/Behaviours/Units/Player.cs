using Data;
using Helpers.Managers;
using UnityEngine;

namespace Behaviours
{
    sealed class Player : MonoBehaviour
    {
        [SerializeField] private UnitData _unitData;

        private UnitAttributes _attributes;
        private IInteracter _interacter;

        public IInteracter Interacter => _interacter;

        private void Awake()
        {
            _attributes = new UnitAttributes(_unitData);
            _interacter = new PlayerInteracter(_attributes,transform);
        }
        private void OnEnable()
        {
            _attributes.Subscribe();
        }
        private void OnDisable()
        {
            _attributes.Unsubscribe();
        }
    }
    interface IInteracter
    {
        float IntracteDistance { get; }
        void MakeInteraction(IInteractable interactable);
        bool CheckInteraction();
    }
    interface IInteractable
    {
        void Interact();
    }
    class PlayerInteracter : IInteracter
    {
        private float _interactDistance;
        private Transform _transform;
        private Collider[] _resultColliders;

        public PlayerInteracter(UnitAttributes _attributes, Transform transform)
        {
            _interactDistance = _attributes.InteractDistance;
            _resultColliders = new Collider[3];
            _transform = transform;
        }

        public float IntracteDistance => _interactDistance;

        public bool CheckInteraction()
        {
            var objectsInRaidus = Physics.OverlapSphereNonAlloc
                (_transform.position, IntracteDistance,
                _resultColliders, LayersManager.Interactable);

            if (objectsInRaidus > 0)
            {
                var interactable = _resultColliders[0].GetComponent<IInteractable>();
                if(interactable != null)
                {
                    MakeInteraction(interactable);
                    return true;
                }
                return false;
            }
            return false;
        }

        public void MakeInteraction(IInteractable interactable)
        {
            interactable.Interact();
        }
    }
}
