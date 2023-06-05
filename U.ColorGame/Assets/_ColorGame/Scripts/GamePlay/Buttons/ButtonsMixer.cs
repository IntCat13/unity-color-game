using System.Collections.Generic;
using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    // This class is responsible for mixing buttons
    public class ButtonsMixer : MonoBehaviour
    {
        // Lists to store buttons and their states
        private List<GameButton> _buttons;
        private List<ButtonState> _buttonStates;

        private void Awake()
        {
            _buttons = new List<GameButton>();
            _buttonStates = new List<ButtonState>();
        }

        // Method to get functionality of buttons randomization
        public IRandomButtonState Random()
        {
            if (_buttons.Count <= 0)
                return null;
            
            return _buttons[0].StatesConfig as IRandomButtonState;
        }
        
        // Method to mix buttons
        // It is called when the game starts
        public void MixButtons()
        {
            foreach (var button in _buttons)
            {
                // Set random state for each button
                button.SetState(button.StatesConfig.GetRandomState());
                // Check if the button state is not unique
                while(_buttonStates.Contains(button.StateMachine.GetState()))
                    button.SetState(button.StatesConfig.GetRandomState());
                
                // Add button state to the list to check if it is unique
                if(!_buttonStates.Contains(button.StateMachine.GetState()))
                    _buttonStates.Add(button.StateMachine.GetState());
            }
        }
        
        // Method to add button to the list
        // It is called when the button is created
        public void AddButton(GameButton button)
        {
            if (_buttons.Contains(button))
                return;
            _buttons.Add(button);
        }
        
        // Method to check if the button state is unique
        public bool IsButtonStateNotExists(ButtonState state)
            => !_buttonStates.Contains(state);
    }
}
