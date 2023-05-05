using _ColorGame.Scripts.GamePlay.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay
{
    public class Button : MonoBehaviour
    {
        public ButtonUI UI;
        [SerializeField] private IButtonState[] _buttonStates;
        private IButtonState _currentState;
        
        void Start()
        {
            // Set up default state
            _currentState = new NullState();
        }

        private void OnClick()
        {
            // Action after button click here
        }
    }
}
