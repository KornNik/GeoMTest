namespace Behaviours
{
    sealed class ComponentsInitializer : BaseInitializer
    {
        protected override void FillInitializers()
        {
            Initializers.Add(new CamerasInitializer());
            Initializers.Add(new LoadersInitializer());
            Initializers.Add(new GameStateControllerInitializer());
        }
    }
}
