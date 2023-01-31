using UnityEngine;




namespace RPG
{
    public static class Initialazier
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        static void Initialize()
        {
            GameObject gameController = new GameObject("GameController");
            gameController.AddComponent<GameController>();
        }
    }
}

