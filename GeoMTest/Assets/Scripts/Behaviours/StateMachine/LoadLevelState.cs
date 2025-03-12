using Helpers;
using System.Threading.Tasks;
using System;
using UnityEngine;

namespace Behaviours
{
    sealed class LoadLevelState : BaseState
    {
        private LoadersStorage _loaders;

        public LoadLevelState(GameStateController stateController) : base(stateController)
        {
            _loaders = Services.Instance.Loaders.ServicesObject;

        }

        public override void EnterState()
        {
            base.EnterState();
            LoadAll();
        }
        private async void LoadAll()
        {
            await LoadTask(LoadLevelBehaviours);
            await LoadTask(LoadObjects);
            await LoadTask(StartGameState);
        }

        private async Task LoadTask(Action loadingAction)
        {
            loadingAction?.Invoke();
            await Task.Yield();
        }
        private void LoadLevelBehaviours()
        {
            _loaders.LevelLoader.LoadLevelByIndex(0);
        }
        private void LoadObjects()
        {
            _loaders.PlayerLoader.LoadOnPlace(Services.Instance.Level.ServicesObject.PlayerSpawn.position);
            _loaders.BoosterLoader.LoadOnPlace(Services.Instance.Level.ServicesObject.BoosterSpawn.position);
        }
        private void StartGameState()
        {
            ChangeGameStateEvent.Trigger(GameStateType.GameState);
        }
    }
}
