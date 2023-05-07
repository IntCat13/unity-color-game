using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.GameManagement.Timer
{
// Class that manage time
// it's count time in seconds and write in in normalized form from 0 to 1
// when timer is ends it's call event and reset it's value
    public class Timer : MonoBehaviour
    {
        [Header("Timer events")] public Action OnTimerEnd;

        [Space] [Header("Timer settings")] [SerializeField]
        private float _timeValue;

        public bool IsTimerActive { get; private set; }
        public float TimeNormalized { get; private set; }
        private float _timer;

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
                }
            }
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
            _timer = _timeValue;
        }
    }
}
