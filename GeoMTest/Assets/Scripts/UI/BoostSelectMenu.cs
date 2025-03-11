using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    class BoostSelectMenu : BaseUI
    {
        [SerializeField] private LayoutGroup _boostsGroup;


        private void OnEnable()
        {
        }
        private void OnDisable()
        {
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
    }
}
