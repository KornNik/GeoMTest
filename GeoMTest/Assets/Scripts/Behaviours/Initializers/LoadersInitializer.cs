using Helpers;

namespace Behaviours
{
    sealed class LoadersInitializer : IInitialization
    {
        public void Initialization()
        {
            var loadersStorage = new LoadersStorage();
            Services.Instance.Loaders.SetObject(loadersStorage);
        }
    }
}
