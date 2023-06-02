using System.Collections.Generic;
using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    public class ButtonsMixer : MonoBehaviour
    {
        private List<GameButton> _buttons;
        private List<ButtonState> _buttonStates;

        private void Awake()
        {
            _buttons = new List<GameButton>();
            _buttonStates = new List<ButtonState>();
        }

        private void Start()
        {
            foreach (var button in _buttons)
            {
                button.SetState(button.StatesConfig.GetRandomState());
                while(_buttonStates.Contains(button.StateMachine.GetState()))
                    button.SetState(button.StatesConfig.GetRandomState());
            }
        }
        
        public void AddButton(GameButton button)
        {
            if (_buttons.Contains(button))
                return;
            _buttons.Add(button);
        }
        
        public bool IsButtonStateNotExists(ButtonState state)
            => !_buttonStates.Contains(state);
    }
}
