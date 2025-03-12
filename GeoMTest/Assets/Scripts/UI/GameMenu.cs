using Behaviours;
using Helpers;
using Helpers.Extensions;
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
            AttributesRequestEvent.Trigger();
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
            var health = StringBuilderExtender.CreateString
                ("Health is ", attributesInfo.Health.ToString());
            var damage = StringBuilderExtender.CreateString
                ("Damage is ", attributesInfo.Damage.ToString());
            var speed = StringBuilderExtender.CreateString
                ("Speed is ", attributesInfo.Speed.ToString());

            _health.text = health;
            _damage.text = damage;
            _speed.text = speed;
        }

        public void OnEventTrigger(AttributesInfoEvent eventType)
        {
            FillAttributes(eventType.AttributesInfo);
        }
    }
}