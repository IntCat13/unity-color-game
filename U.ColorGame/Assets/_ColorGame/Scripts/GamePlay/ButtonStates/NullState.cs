using _ColorGame.Scripts.GamePlay;
using _ColorGame.Scripts.GamePlay.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.ButtonStates
{
    public class NullState : IButtonState
    {
        private Color _stateColor = Color.gray;
    
        // Set button color to gray
        public void OnEnter(Button button)
        {
            button.UI.SetColor(_stateColor);
        }
    }
}
