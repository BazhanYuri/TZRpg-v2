using UnityEngine;



namespace RPG
{
    public class CharacterSelector
    {
        private CharacterTypes _characterTypes;
        private SelectorScreen _selectorScreen;

        private int _typesCount;
        private GameObject _currentSkin;

        private Character _character;
        
        public void Init(CharacterTypes characterTypes, SelectorScreen selectorScreen)
        {
            _characterTypes = characterTypes;
            _selectorScreen = selectorScreen;

            _typesCount = _characterTypes.Skins.Length;
            _selectorScreen.OnGenerateButtonPressed += SelectRandomCharacter;

        }
        public void Init(Character character, CharacterTypes characterTypes)
        {
            _characterTypes = characterTypes;
            _character = character;
            _character.SetCurrentType(SetCurrentCharacterType());
        }

        private void SelectRandomCharacter()
        {
            if (_currentSkin != null)
            {
                GameObject.Destroy(_currentSkin.gameObject);
            }

            int index = Random.Range(0, _typesCount);
            _currentSkin = GameObject.Instantiate(_characterTypes.Skins[index].Skin) as GameObject;
            PlayerPrefs.SetInt(PrefsKeys.CurrentPlayerType, index);
        }
        private CharacterInfo SetCurrentCharacterType()
        {
            return _characterTypes.Skins[PlayerPrefs.GetInt(PrefsKeys.CurrentPlayerType)];
        }
        
    }
}

