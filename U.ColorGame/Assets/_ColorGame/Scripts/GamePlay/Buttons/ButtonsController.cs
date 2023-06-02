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

        public void ClickAnyButton(ButtonState state, IRandomButtonState random)
        {
            if (IsButtonIsExpected(state))
            {
                OnClickedRightButton?.Invoke();
                RandomizeNextButton(random);
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
    }
}
