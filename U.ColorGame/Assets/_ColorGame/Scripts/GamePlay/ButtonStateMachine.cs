using System.Collections;
using System.Collections.Generic;
using _ColorGame.Scripts.GamePlay.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay
{
    // This class is a state machine for the button
    public class ButtonStateMachine
    {
        // Set up default state
        public IButtonState GetState() => _currentState;
        private IButtonState _currentState;
        private ButtonStatesConfig _statesConfig;
        
        public void SetState(IButtonState state, Button button)
        {
            _currentState = state;
            _currentState.OnEnter(button);
        }
        
        public void Initialize(ButtonStatesConfig statesConfig, Button button)
        {
            _statesConfig = statesConfig;
            _currentState = _statesConfig.NullState;
            _currentState.OnEnter(button);
        }
    }
}