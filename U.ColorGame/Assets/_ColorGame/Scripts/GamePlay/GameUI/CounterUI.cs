using _ColorGame.Scripts.GamePlay.GameManagement;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.GameUI
{
    // This class is responsible for updating counter UI
    public class CounterUI : MonoBehaviour
    {
        [Inject] private ScoreCounter _scoreCounter;
        [SerializeField] private Text _counterText;

        private void Start()
        {
            _scoreCounter.OnScoreChanged += UpdateCounterUI;
        }

        private void UpdateCounterUI()
        {
            _counterText.text = _scoreCounter.Score.ToString();
        }
    }
}