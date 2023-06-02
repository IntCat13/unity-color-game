using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using UnityEngine;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    public class GameButton : MonoBehaviour
    {
        [Inject] public readonly ButtonStatesConfig StatesConfig;
        public readonly ButtonStateMachine StateMachine = new ButtonStateMachine();
        
        [Header("Button UI")]
        public ButtonUI UI;
        [Space]
        
        [Inject] private ButtonsMixer _mixer;
        [Inject] private ButtonsController _controller;

        private void Awake()
        {
            // Initialize state machine
            StateMachine.Initialize(StatesConfig, this);
        }

        private void Start()
        {
            _mixer.AddButton(this);
        }

        public void OnClick()
        {
            _controller.ClickAnyButton(StateMachine.GetState(), StatesConfig);
        }
        
        public void SetState(ButtonState state)
        {
            // Set state of the button
            StateMachine.SetState(state, this);
        }
    }
}
