namespace Behaviours
{
    sealed class ComponentInitializerAsync : BaseInitializerAsync
    {
        protected override void FillInitializers()
        {
            Initializers.Add(new CameraInitializerAsync());
            Initializers.Add(new LoadersInitializerAsync());
            Initializers.Add(new GameStateInitializerAsync());
        }
    }
}
