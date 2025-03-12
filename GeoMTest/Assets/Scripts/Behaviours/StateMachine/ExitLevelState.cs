using Helpers;
using System.Threading.Tasks;
using System;

namespace Behaviours
{
    sealed class ExitLevelState : BaseState
    {
        private LoadersStorage _loaders;
        public ExitLevelState(GameStateController stateController) : base(stateController)
        {
            _loaders = Services.Instance.Loaders.ServicesObject;
        }
        public override void EnterState()
        {
            base.EnterState();
            DeleteAll();
        }

        private async void DeleteAll()
        {
            await LoadTask(DeleteObjects);
            await LoadTask(DeleteLevel);
        }
        private async Task LoadTask(Action loadingAction)
        {
            loadingAction?.Invoke();
            await Task.Yield();
        }
        private void DeleteLevel()
        {
            _loaders.LevelLoader.ClearLevelFull();
        }
        private void DeleteObjects()
        {
            _loaders.PlayerLoader.Clear();
            _loaders.BoosterLoader.Clear();
        }
        private void StartGameState()
        {
            ChangeGameStateEvent.Trigger(GameStateType.MenuState);
        }
    }
}
