using Data;
using Helpers;
using UnityEngine;

namespace Behaviours
{
    struct SendingBoostersInfo
    {
        public Sprite Sprite;
        public string Description;
        public string Title;

        public SendingBoostersInfo(Sprite sprite, string description, string title)
        {
            Sprite = sprite;
            Description = description;
            Title = title;
        }
    }
    struct BoosterSendInfoEvent
    {
        private BoosterData[] _boostersInfo;
        private static BoosterSendInfoEvent _boostersPickUpEvent;

        public BoosterData[] BoostersInfo => _boostersInfo;

        public static void Trigger(BoosterData[] boostersInfo)
        {
            _boostersPickUpEvent._boostersInfo = boostersInfo;
            EventManager.TriggerEvent(_boostersPickUpEvent);
        }
    }
}
