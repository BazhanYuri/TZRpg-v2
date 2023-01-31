using System;
using UnityEngine;
using UnityEngine.UI;



namespace RPG
{
    public class GamePlayScreen
    {
        public event Action OnBackToSelectorPressed;


        private Button _backToSelectorButton;

        public void Init(Button backToSelectorButton)
        {
            _backToSelectorButton = backToSelectorButton;

            _backToSelectorButton.onClick.AddListener(CallOnBckToSelButtonPressed);
        }
        public void Close()
        {
            _backToSelectorButton.onClick.RemoveListener(CallOnBckToSelButtonPressed);
        }

        private void CallOnBckToSelButtonPressed()
        {
            OnBackToSelectorPressed?.Invoke();
        }
    }
}

