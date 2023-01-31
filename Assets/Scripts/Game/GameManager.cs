using UnityEngine;
using UnityEngine.SceneManagement;



namespace RPG
{
    public class GameManager
    {
        private SelectorScreen _selectorScreen;
        private GamePlayScreen _gamePlayScreen;




        public void Init(SelectorScreen selectorScreen)
        {
            _selectorScreen = selectorScreen;
            _selectorScreen.OnPlayButtonPressed += LoadGameLevel;
        }
        public void Init(GamePlayScreen gamePlayScreen)
        {
            _gamePlayScreen = gamePlayScreen;
            _gamePlayScreen.OnBackToSelectorPressed += LoadSelectorLevel;
        }
        private void LoadGameLevel()
        {
            SceneManager.LoadScene("Game");
        }
        private void LoadSelectorLevel()
        {
            SceneManager.LoadScene("CharacterSelector");
        }
    }
}

