using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    // This class is responsible for storing game settings
    [CreateAssetMenu(fileName = "Game Config", menuName = "Game Settings/New Game Config")]
    public class GameConfig : ScriptableObject
    {
        public float StartGameTime;
        public float TimeScaler;
        public float MinTime;
    }
}
