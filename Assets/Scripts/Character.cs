using UnityEngine;





namespace RPG
{
    public class Character
    {
        private CharacterInfo _characterInfo;
        private GameObject _skin;

        public void SetCurrentType(CharacterInfo characterInfo)
        {
            _characterInfo = characterInfo;

            _skin = GameObject.Instantiate(_characterInfo.Skin) as GameObject;
        }

        public void Init()
        {

        }
    }
}
