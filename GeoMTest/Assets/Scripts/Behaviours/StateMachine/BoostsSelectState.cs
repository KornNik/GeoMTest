using UI;

namespace Behaviours
{
    sealed class BoostsSelectState : BaseState
    {
        public BoostsSelectState(GameStateController stateController) : base(stateController)
        {

        }

        public override void EnterState()
        {
            ScreenInterface.GetInstance().Execute(Helpers.ScreenTypes.BoostsMenu);
        }

        public override void ExitState()
        {
        }

        public override void LogicFixedUpdate()
        {
        }

        public override void LogicUpdate()
        {
        }

        private void EndState()
        {

        }
    }
}