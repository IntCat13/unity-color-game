using _ColorGame.Scripts.GamePlay.Buttons;
using _ColorGame.Scripts.GamePlay.GameManagement.Timer;
using UnityEngine;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    // This class is responsible for game management
    public class GameController : MonoBehaviour
    {
        [Inject] private GameEvents _gameEvents;
        [Inject] private GameConfig _gameConfig;
        [Inject] private GameTimer _timer;
        [Inject] private ScoreCounter _scoreCounter;
        
        [Inject] private ButtonsController _buttonsController;

        // Temporary solution for starting game
        private void Start()
        {
            StartGame();
        }
        
        // Initialize game event and start game
        // TODO: Move events initialization to separate class
        public void StartGame()
        {
            // Initialize timer
            _timer.Initialize(_gameConfig);
            _timer.OnTimerEnd += EndGame;

            // Initialize buttons
            _buttonsController.InitializeButtons();
            
            // Initialize game events
            _buttonsController.OnClickedRightButton += _timer.ResetTimer;
            _buttonsController.OnClickedRightButton += _timer.SetColor;
            _buttonsController.OnClickedRightButton += _scoreCounter.AddScore;
            _gameEvents.GameStart();
            
            // Start timer
            _timer.StartTimer();
        }

        public void EndGame()
        {
            _gameEvents.GameOver();
        }
        
        public void PauseGame()
        {
            _timer.StopTimer();
        }
        
        public void ContinueGame()
        {
            _timer.StartTimer();
        }
    }
}
