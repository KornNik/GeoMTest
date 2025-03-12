using Behaviours;
using Data;
using Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    class BoostSelectMenu : BaseUI, IEventListener<BoosterSendInfoEvent>
    {
        [SerializeField] private LayoutGroup _boostsGroup;

        private BoostSlot[] _slots;

        protected override void Awake()
        {
            _slots = _boostsGroup.GetComponentsInChildren<BoostSlot>();
        }

        private void OnEnable()
        {
            this.EventStartListening<BoosterSendInfoEvent>();
        }
        private void OnDisable()
        {
            this.EventStopListening<BoosterSendInfoEvent>();
        }

        private void FillSlots(BoosterData[] boostersData)
        {
            for (int i = 0; i < _slots.Length; i++)
            {
                _slots[i].FillSlot(boostersData[i]);
            }
        }

        public override void Show()
        {
            gameObject.SetActive(true);
            ShowUI.Invoke();

        }
        public override void Hide()
        {
            gameObject.SetActive(false);
            HideUI.Invoke();
        }
        public void OnEventTrigger(BoosterSendInfoEvent eventType)
        {
            FillSlots(eventType.BoostersInfo);
        }
    }
}
