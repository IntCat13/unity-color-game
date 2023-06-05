using System;
using UnityEngine;
using UnityEngine.Events;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    // This class is responsible for storing game events
    public class GameEvents : MonoBehaviour
    {
        public Action gameOverEvent;
        public Action gameStartEvent;

        public void GameOver()
        {
            gameOverEvent?.Invoke();
        }

        public void GameStart()
        {
            gameStartEvent?.Invoke();
        }
    }
}
