using Behaviours;
using Data;
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

        private BoosterData _data;

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

        public void FillSlot(BoosterData boosterData)
        {
            _image.sprite = boosterData.Sprite;
            _title.text = boosterData.Title;
            _description.text = boosterData.Description;
            _data = boosterData;
        }
        public void ClearSlot()
        {
            _image.sprite = _emptyBoostImage;
            _title.text = null;
            _description.text = null;
        }

        private void OnSelectButtonDown()
        {
            BoostSelectEvent.Trigger(_data);
            ChangeGameStateEvent.Trigger(GameStateType.GameState);
        }
    }
}
