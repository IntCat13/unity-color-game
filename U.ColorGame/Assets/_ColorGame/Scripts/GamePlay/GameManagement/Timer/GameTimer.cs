using System;
using System.Collections;
using System.Collections.Generic;
using _ColorGame.Scripts.Additional.DebugTools;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.GameManagement.Timer
{
// Class that manage time
// it's count time in seconds and write in in normalized form from 0 to 1
// when timer is ends it's call event and reset it's value
    public class GameTimer : MonoBehaviour
    {
        [Header("Timer events")] public Action OnTimerEnd;

        [Space] [Header("Timer settings")] [SerializeField]
        private float _timeValue;

        public bool IsTimerActive { get; private set; }
        public float TimeNormalized { get; private set; }
        
        private float _timer;
        private float _timeScaler;
        private float _minTime;
        
        [Header("Debug info")]
        [SerializeField] private Logs _logger;

        private void FixedUpdate()
        {
            if (IsTimerActive)
            {
                _timer -= Time.deltaTime;
                TimeNormalized = _timer / _timeValue;
                if (_timer <= 0)
                {
                    IsTimerActive = false;
                    OnTimerEnd?.Invoke();
                    _logger.Log("Timer is end", this);
                }
            }
        }

        public void Initialize(GameConfig config)
        {
            _timeValue = config.StartGameTime;
            _timeScaler = config.TimeScaler;
            _minTime = config.MinTime;
            ResetTimer();
        }
        
        public void StartTimer()
        {
            ResetTimer();
            IsTimerActive = true;
        }

        public void StopTimer()
        {
            ResetTimer();
            IsTimerActive = false;
        }

        public void ResetTimer()
        {
            ScaleTime();
            _timer = _timeValue;
        }

        private void ScaleTime()
        {
            if(_timeValue <= _minTime) return;
            _timeValue -= _timeScaler;
        }
    }
}
