using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    struct SlotContent
    {
        public Sprite Sprite;
        public string Title;
        public string Description;

        public SlotContent(Sprite sprite, string title, string description)
        {
            Sprite = sprite;
            Title = title;
            Description = description;
        }
    }
    sealed class BoostSlot : MonoBehaviour
    {
        [SerializeField] private Button _selectButton;
        [SerializeField] private Image _image;
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _description;
        [SerializeField] private Sprite _emptyBoostImage;

        private void Awake()
        {
            
        }
        private void OnEnable()
        {
            _selectButton.onClick.AddListener(OnSelectButtonDown);
        }
        private void OnDisable()
        {
            _selectButton.onClick.RemoveListener(OnSelectButtonDown);
        }

        public void FillSlot(SlotContent slotContent)
        {
            _image.sprite = slotContent.Sprite;
            _title.text = slotContent.Title;
            _description.text = slotContent.Description;
        }
        public void ClearSlot()
        {
            _image.sprite = _emptyBoostImage;
            _title.text = null;
            _description.text = null;
        }

        private void OnSelectButtonDown()
        {

        }
    }
}
