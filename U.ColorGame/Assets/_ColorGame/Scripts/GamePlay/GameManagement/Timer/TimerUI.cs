using UnityEngine;
using UnityEngine.UI;

namespace _ColorGame.Scripts.GamePlay.GameManagement.Timer
{
    public class TimerUI : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField] private Timer _timer;
        [SerializeField] private Image _progressBar;

        private void FixedUpdate()
        {
            _progressBar.fillAmount = _timer.TimeNormalized;
        }
    }
}
