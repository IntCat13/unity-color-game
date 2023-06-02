using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    [CreateAssetMenu(fileName = "Game Config", menuName = "Game Settings/New Game Config")]
    public class GameConfig : ScriptableObject
    {
        public float StartGameTime;
        public float TimeScaler;
        public float MinTime;
    }
}
