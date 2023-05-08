using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace _ColorGame.Scripts.Additional.DebugTools
{
    public class Logs : MonoBehaviour
    {
        [SerializeField] private bool _isDebugMode;
        [SerializeField] private Color _logColor;
        [SerializeField] private string _logPrefix;
        private string _hexColor;
        
        private void OnValidate()
        {
            _hexColor = "#"+ColorUtility.ToHtmlStringRGB(_logColor);
        }

        public void Log(object message, Object sender)
        {
            if (_isDebugMode)
                return;
            
            Debug.Log($"<color={_logColor}>{_logPrefix}: {message}", sender);
        }
    }
}