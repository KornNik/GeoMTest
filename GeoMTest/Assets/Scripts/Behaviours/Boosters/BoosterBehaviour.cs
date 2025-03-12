using Data;
using UnityEngine;

namespace Behaviours
{
    sealed class BoosterBehaviour : MonoBehaviour, IInteractable
    {
        [SerializeField] private Collider _collider;
        [SerializeField] private BoosterData[] _datas;


        public void Interact()
        {
            ChangeGameStateEvent.Trigger(GameStateType.BoostsSelectState);
            BoosterSendInfoEvent.Trigger(_datas);
            gameObject.SetActive(false);
        }
    }
}
