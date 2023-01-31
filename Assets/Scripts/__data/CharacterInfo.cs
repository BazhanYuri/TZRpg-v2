using UnityEngine;





namespace RPG
{
    [CreateAssetMenu(fileName = "CharacterInfo", menuName = "ScriptableObjects/CharacterInfo", order = 1)]

    public class CharacterInfo : ScriptableObject
    {
        [SerializeField] private GameObject _skin;


        public GameObject Skin { get => _skin; }
    }
}

