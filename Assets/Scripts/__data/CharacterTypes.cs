using UnityEngine;




namespace RPG
{
    [CreateAssetMenu(fileName = "CharacterType", menuName = "ScriptableObjects/Characters", order = 1)]
    public class CharacterTypes : ScriptableObject
    {
        [SerializeField] private CharacterInfo[] _skins;



        public CharacterInfo[] Skins { get => _skins; set => _skins = value; }
    }
}


