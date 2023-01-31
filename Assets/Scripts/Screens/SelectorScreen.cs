using System;
using UnityEngine;
using UnityEngine.UI;




namespace RPG
{
    public class SelectorScreen
    {
        public event Action OnGenerateButtonPressed;
        public event Action OnPlayButtonPressed;


        private Button _generateButton;
        private Button _playButton;

        public void Init(Button generateButton, Button playButton)
        {
            _generateButton = generateButton;
            _playButton = playButton;

            _generateButton.onClick.AddListener(CallOnGenerateButtonPressed);
            _playButton.onClick.AddListener(CallOnPlayButtonPressed);
        }
        public void Close()
        {
            _generateButton.onClick.RemoveListener(CallOnGenerateButtonPressed);
            _playButton.onClick.RemoveListener(CallOnPlayButtonPressed);
        }

        private void CallOnGenerateButtonPressed()
        {
            OnGenerateButtonPressed?.Invoke();
        }
        private void CallOnPlayButtonPressed()
        {
            OnPlayButtonPressed?.Invoke();
        }
    }
}

