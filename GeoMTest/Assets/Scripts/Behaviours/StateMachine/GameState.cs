using Helpers;
using UI;

namespace Behaviours
{
    sealed class GameState : BaseState
    {
        private PlayerInputs _inputs;
        public GameState(GameStateController stateController) : base(stateController)
        {
            _inputs = new PlayerInputs();
        }

        public override void EnterState()
        {
            _inputs.Initialization();
            ScreenInterface.GetInstance().Execute(ScreenTypes.GameMenu);
        }

        public override void ExitState()
        {

        }

        public override void LogicFixedUpdate()
        {

        }

        public override void LogicUpdate()
        {
            _inputs.UpdateInputs();
        }
    }
}
