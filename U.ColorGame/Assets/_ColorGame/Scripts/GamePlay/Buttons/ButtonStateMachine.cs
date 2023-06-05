using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    // This class is a state machine for the button
    public class ButtonStateMachine
    {
        // Set up default state
        public ButtonState GetState() => _currentState;
        private ButtonState _currentState;
        private ButtonStatesConfig _statesConfig;
        
        public void SetState(ButtonState state, GameButton button)
        {
            _currentState = state;
            _currentState.OnEnter(button);
        }
        
        // Initialize state machine
        public void Initialize(ButtonStatesConfig statesConfig, GameButton button)
        {
            _statesConfig = statesConfig;
            _currentState = _statesConfig.NullState;
            _currentState.OnEnter(button);
        }
    }
}