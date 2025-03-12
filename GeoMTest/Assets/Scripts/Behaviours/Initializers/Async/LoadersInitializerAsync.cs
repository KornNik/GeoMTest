using Cysharp.Threading.Tasks;
using Helpers;

namespace Behaviours
{
    sealed class 
        LoadersInitializerAsync : IInitializationAsync
    {
        public async UniTask InitializationAsync()
        {
            var loadersStorage = new LoadersStorage();
            Services.Instance.Loaders.SetObject(loadersStorage);
            await UniTask.Yield();
        }
    }
}
