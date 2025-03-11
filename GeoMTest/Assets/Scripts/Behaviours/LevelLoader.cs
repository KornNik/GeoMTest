using UnityEngine;
using Data;
using Helpers;

namespace Behaviours
{
    class LevelLoader : ILevelLoader
    {
        private GameObject _level;
        private LevelData _levelData;
        private LevelsBundle _levelsBundle;

        private int _levelIndex = 0;

        public LevelLoader()
        {
            _levelsBundle = Services.Instance.DataResourcePrefabs.ServicesObject.GetLevelsBundle();
        }

        public void LoadLevelByIndex(int index)
        {
            LoadLevelVisuals(index);
        }
        public bool LoadNextLevel()
        {
            if (!IsLastLevel())
            {
                _levelIndex++;
                LoadLevelByIndex(_levelIndex);
                return true;
            }
            return false;
        }
        public void ResetLevels()
        {
            _levelIndex = 0;
        }
        public void ClearLevelFull()
        {
            if (!ReferenceEquals(_level, null))
            {
                GameObject.Destroy(_level.gameObject);
                _level = null;
            }
        }
        public bool IsLastLevel()
        {
            return _levelsBundle.IsLastLevelByIndex(_levelIndex);
        }

        private void LoadLevelVisuals(int index)
        {
            _levelData = _levelsBundle.GetRandomLevelData();
            _level = GameObject.Instantiate(_levelData.LevelPrefab, _levelData.LevelPosition, Quaternion.identity).gameObject;
            _level.transform.localPosition = Vector3.zero;
            _level.transform.localRotation = Quaternion.identity;
        }
    }
    interface IObjectLoader
    {
        void Load();
        void Clear();
    }
    sealed class PlayerLoader
    {
        private Player _player;
        
        private void Load()
        {

        }
        private void Clear()
        {

        }
    }
    sealed class BoosterLoader
    {
        private BoosterBehaviour _booster;
        private void Load()
        {

        }
        private void Clear()
        {

        }
    }
}
