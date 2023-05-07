using System.Collections;
using System.Collections.Generic;
using _ColorGame.Scripts.GamePlay.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay
{
    // This class is a state machine for the button
    // It is a ScriptableObject so that it can be shared between all buttons
    [CreateAssetMenu(menuName = "Button State Machine")]
    public class ButtonStateMachine : ScriptableObject
    {
        // Set up default state
        public IButtonState GetState() => _currentState;
        private IButtonState _currentState;
        private ButtonStatesConfig _statesConfig;
        
        public void SetState(IButtonState state)
        {
            _currentState = state;
        }
        
        public void Initialize(ButtonStatesConfig statesConfig)
        {
            _statesConfig = statesConfig;
            _currentState = _statesConfig.NullState;
        }
    }
}