using UnityEngine;
using UnityEngine.UI;



namespace RPG
{
    public class GamePlayLevel : MonoBehaviour
    {
        [SerializeField] private Button _toSelectorScreenBtn;
        [SerializeField] private CharacterTypes _characterTypes;

        public CharacterTypes CharacterTypes { get => _characterTypes; set => _characterTypes = value; }
        public Button ToSelectorScreenBtn { get => _toSelectorScreenBtn; set => _toSelectorScreenBtn = value; }
    }
}

