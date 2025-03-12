using Helpers;
using Helpers.Extensions;

namespace Behaviours
{
    class PlayerInputs : IInitialization
    {
        private Player _player;
        private InputActions _inputs;
        public PlayerInputs()
        {
            _inputs = Services.Instance.Inputs.ServicesObject;
        }

        public void Initialization()
        {
            _player = Services.Instance.Player.ServicesObject;
        }

        public void UpdateInputs()
        {
            var isInteracting = _inputs.PlayerActionList[InputActionsNames.INTERACT].IsPressed();
            if (isInteracting)
            {
                _player.Interacter.CheckInteraction();
            }
        }
    }
}
