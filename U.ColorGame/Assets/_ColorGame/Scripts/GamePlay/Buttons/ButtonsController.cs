using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using UnityEngine;
using Zenject;
using System;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    public class ButtonsController : MonoBehaviour
    {
        public Action OnClickedRightButton;
        private ButtonState _expectedButtonState;
        [Inject] private ButtonsMixer _mixer;

        public Color GetColor()
            => _expectedButtonState.GetColor();

        public void ClickAnyButton(ButtonState state, IRandomButtonState random)
        {
            if (IsButtonIsExpected(state))
            {
                RandomizeNextButton(random);
                OnClickedRightButton?.Invoke();
            }
        }
        
        public bool IsButtonIsExpected(ButtonState state) 
            => state == _expectedButtonState;

        public void RandomizeNextButton(IRandomButtonState random)
        {
            do
            {
                _expectedButtonState = random.GetRandomState(_expectedButtonState);
            } while (_mixer.IsButtonStateNotExists(_expectedButtonState));
        }

        public void InitializeButtons()
        {
            _mixer.MixButtons();
            RandomizeNextButton(_mixer.Random());
        }
    }
}
