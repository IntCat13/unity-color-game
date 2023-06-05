using UnityEngine;
using UnityEngine.UI;

namespace _ColorGame.Scripts.GamePlay.GameManagement.Timer
{
    // This class is responsible for updating the timer UI
    public class TimerUI : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private GameTimer _timer;
        [SerializeField] private Image _progressBar;

        // Set timer UI color to current timer color
        public void SetColor()
        {
            _progressBar.color = _timer.CurrentColor;
        }
        
        // Update timer UI progress bar
        private void FixedUpdate()
        {
            _progressBar.fillAmount = _timer.TimeNormalized;
        }

        // Subscribe to timer events on awake
        private void Awake()
        {
            _timer.OnTimerChanged += SetColor;
        }     
    }
}
