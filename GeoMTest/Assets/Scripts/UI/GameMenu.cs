using Behaviours;
using Helpers;
using TMPro;
using UnityEngine;

namespace UI
{
    class GameMenu : BaseUI, IEventListener<AttributesInfoEvent>
    {
        [SerializeField] private TMP_Text _health;
        [SerializeField] private TMP_Text _damage;
        [SerializeField] private TMP_Text _speed;

        private void OnEnable()
        {
            this.EventStartListening<AttributesInfoEvent>();
        }
        private void OnDisable()
        {
            this.EventStopListening<AttributesInfoEvent>();
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

        private void FillAttributes(SendingAttributesInfo attributesInfo)
        {
            _health.text = attributesInfo.Health.ToString();
            _damage.text = attributesInfo.Damage.ToString();
            _speed.text = attributesInfo.Speed.ToString();
        }

        public void OnEventTrigger(AttributesInfoEvent eventType)
        {
            FillAttributes(eventType.AttributesInfo);
        }
    }
}