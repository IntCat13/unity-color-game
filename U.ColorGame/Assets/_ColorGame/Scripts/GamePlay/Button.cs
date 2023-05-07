using _ColorGame.Scripts.GamePlay.ButtonStates;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay
{
    public class Button : MonoBehaviour
    {
        [Header("Button UI")]
        public ButtonUI UI;
        [Space]
        
        [Header("State Machine Configuration")]
        private ButtonStateMachine _stateMachine = new ButtonStateMachine();
        [SerializeField] private ButtonStatesConfig _statesConfig;

        void Start()
        {
            // Initialize state machine
            _stateMachine.Initialize(_statesConfig, this);
        }

        private void OnClick()
        {
            // Action after button click here
            _stateMachine.SetState(_statesConfig.BlueState, this);
        }
    }
}
