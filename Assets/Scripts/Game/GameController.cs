using UnityEngine;
using UnityEngine.SceneManagement;



namespace RPG
{
    public enum LevelType
    {
        Selector,
        Gameplay
    }
    public class GameController : MonoBehaviour
    {
        private SelectorLevel _selectorLevel;
        private GamePlayLevel _gamePlayLevel;

        private GameManager _gameManager;

        private SelectorScreen _selectorScreen;
        private CharacterSelector _characterSelector;

        private GamePlayScreen _gamePlayScreen;

        private Character _character;

        private LevelType _levelType = LevelType.Selector;

        public static GameController Instance;



       
        private void OnEnable()
        {
            Open();
            SceneManager.sceneLoaded += Open;
            SceneManager.sceneUnloaded += Close;
        }
        private void OnDisable()
        {
            SceneManager.sceneLoaded -= Open;
            SceneManager.sceneUnloaded -= Close;
        }


        private void Open(Scene scene, LoadSceneMode mode)
        {
            Open();
        }
        private void Open()
        {
            _gameManager = new GameManager();
            switch (_levelType)
            {
                case LevelType.Selector:
                    InitSelector();
                    break;
                case LevelType.Gameplay:
                    InitGamePlay();
                    break;
                default:
                    break;
            }


            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
            DontDestroyOnLoad(this);
        }
        private void Close(Scene scene)
        {
            switch (_levelType)
            {
                case LevelType.Selector:
                    CloseSelector();
                    break;
                case LevelType.Gameplay:
                    CloseGamePlay();
                    break;
                default:
                    break;
            }

        }
        private void InitSelector()
        {
            _selectorLevel = FindObjectOfType<SelectorLevel>();

            _selectorScreen = new SelectorScreen();
            _characterSelector = new CharacterSelector();

            _selectorScreen.Init(_selectorLevel.GenerateBtn, _selectorLevel.PlayBtn);
            _gameManager.Init(_selectorScreen);
            _characterSelector.Init(_selectorLevel.CharacterTypes, _selectorScreen);

            _selectorScreen.OnPlayButtonPressed += SetAsGamePlay;
        }
        private void CloseSelector()
        {
            _selectorScreen.OnPlayButtonPressed -= SetAsGamePlay;

            _selectorScreen.Close();
        }
        private void InitGamePlay()
        {
            _character = new Character();
            _gamePlayScreen = new GamePlayScreen();
            _characterSelector = new CharacterSelector();

            _gamePlayLevel = FindObjectOfType<GamePlayLevel>();
            _gamePlayScreen.Init(_gamePlayLevel.ToSelectorScreenBtn);
            _gameManager.Init(_gamePlayScreen);
            _characterSelector.Init(_character, _gamePlayLevel.CharacterTypes);

            _gamePlayScreen.OnBackToSelectorPressed += SetAsSelectorLevel;
        }
        private void CloseGamePlay()
        {
            _selectorScreen.OnPlayButtonPressed -= SetAsSelectorLevel;
        }
        private void SetAsGamePlay()
        {
            _levelType = LevelType.Gameplay;
        }
        private void SetAsSelectorLevel()
        {
            _levelType = LevelType.Selector;
        }
    }
}

