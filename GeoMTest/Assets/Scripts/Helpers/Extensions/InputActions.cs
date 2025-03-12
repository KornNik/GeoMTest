using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Helpers.Extensions
{
    internal class InputActions
    {
        private Dictionary<string, InputAction> _playerActionList = new Dictionary<string, InputAction>();

        public Dictionary<string, InputAction> PlayerActionList => _playerActionList;

        public InputActions(InputActionMap playerActionMap)
        {
            InitializeActions(playerActionMap);
        }

        private void InitializeActions(InputActionMap playerActionMap)
        {
            _playerActionList.Add(InputActionsNames.FIRE, playerActionMap.FindAction(InputActionsNames.FIRE));
            _playerActionList.Add(InputActionsNames.MOVEMENT, playerActionMap.FindAction(InputActionsNames.MOVEMENT));
            _playerActionList.Add(InputActionsNames.AIM, playerActionMap.FindAction(InputActionsNames.AIM));
            _playerActionList.Add(InputActionsNames.JUMP, playerActionMap.FindAction(InputActionsNames.JUMP));
            _playerActionList.Add(InputActionsNames.LOOK, playerActionMap.FindAction(InputActionsNames.LOOK));
            _playerActionList.Add(InputActionsNames.INTERACT, playerActionMap.FindAction(InputActionsNames.INTERACT));
            _playerActionList.Add(InputActionsNames.RELOAD, playerActionMap.FindAction(InputActionsNames.RELOAD));
            _playerActionList.Add(InputActionsNames.HOLSTER, playerActionMap.FindAction(InputActionsNames.HOLSTER));
            _playerActionList.Add(InputActionsNames.RUN, playerActionMap.FindAction(InputActionsNames.RUN));
        }
    }
}
