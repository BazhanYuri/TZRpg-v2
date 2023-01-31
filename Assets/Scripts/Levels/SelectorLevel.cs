using UnityEngine;
using UnityEngine.UI;




namespace RPG
{
    public class SelectorLevel : MonoBehaviour
    {
        [SerializeField] private CharacterTypes _characterTypes;
        [SerializeField] private Button _generateBtn;
        [SerializeField] private Button _playBtn;

        public CharacterTypes CharacterTypes { get => _characterTypes; set => _characterTypes = value; }
        public Button GenerateBtn { get => _generateBtn; set => _generateBtn = value; }
        public Button PlayBtn { get => _playBtn; set => _playBtn = value; }
    }
}

