using System;
using UnityEngine;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    // This class is responsible for counting score
    public class ScoreCounter : MonoBehaviour
    {
        public int Score { get; private set; }
        public Action OnScoreChanged;
        
        public void AddScore()
        {
            Score ++;
            OnScoreChanged?.Invoke();
        }
    }
}