using Data;
using Helpers;

namespace UI
{
    struct BoostSelectEvent
    {
        private static BoostSelectEvent _boostSelectEvent;
        private BoosterData _data;

        public BoosterData Data  => _data;

        public static void Trigger(BoosterData data)
        {
            _boostSelectEvent._data = data;
            EventManager.TriggerEvent(_boostSelectEvent);
        }
    }
}
