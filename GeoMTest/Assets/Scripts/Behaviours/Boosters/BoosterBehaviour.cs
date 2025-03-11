using UnityEngine;

namespace Behaviours
{
    sealed class BoosterBehaviour : MonoBehaviour, IInteractable
    {
        [SerializeField] private Collider _collider;
        private BoosterModifier[] _modifiers;

        public void Interact()
        {

        }
    }
}
