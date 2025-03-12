namespace Behaviours
{
    sealed class LoadersStorage
    {
        private IObjectLoader _playerLoader;
        private IObjectLoader _boosterLoader;
        private ILevelLoader _levelLoader;

        public LoadersStorage()
        {
            _levelLoader = new LevelLoader();
            _playerLoader = new PlayerLoader();
            _boosterLoader = new BoosterLoader();
        }

        public IObjectLoader PlayerLoader  => _playerLoader;
        public IObjectLoader BoosterLoader => _boosterLoader;
        public ILevelLoader LevelLoader => _levelLoader; 
    }
}
