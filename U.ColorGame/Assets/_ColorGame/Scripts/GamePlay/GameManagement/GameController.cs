using _ColorGame.Scripts.GamePlay.Buttons;
using _ColorGame.Scripts.GamePlay.GameManagement.Timer;
using UnityEngine;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.GameManagement
{
    public class GameController : MonoBehaviour
    {
        [Inject] private GameEvents _gameEvents;
        [Inject] private GameConfig _gameConfig;
        [Inject] private GameTimer _timer;
        
        [Inject] private ButtonsController _buttonsController;

        public void StartGame()
        {
            _timer.Initialize(_gameConfig);
            _timer.OnTimerEnd += EndGame;
            
            _buttonsController.OnClickedRightButton += _timer.ResetTimer;
            _gameEvents.GameStart();
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
