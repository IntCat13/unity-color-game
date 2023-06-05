using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    // This class is responsible for storing game button logic
    public class GameButton : MonoBehaviour, IPointerClickHandler
    {
        [Inject] public readonly ButtonStatesConfig StatesConfig;
        public readonly ButtonStateMachine StateMachine = new ButtonStateMachine();
        
        [Header("Button UI")]
        public ButtonUI UI;
        [Space]
        
        [Inject] private ButtonsMixer _mixer;
        [Inject] private ButtonsController _controller;
        
        private Animator _animation;

        // Initialize button
        private void Awake()
        {
            _animation = GetComponent<Animator>();

            // Initialize state machine
            StateMachine.Initialize(StatesConfig, this);
            
            //StateMachine.Initialize(StatesConfig, this);
            _mixer.AddButton(this);
        }
        
        public void OnPointerClick(PointerEventData pointerEventData)
        {
            _animation.SetTrigger("Click");
            _controller.ClickAnyButton(StateMachine.GetState(), StatesConfig);
        }
        
        public void SetState(ButtonState state)
        {
            // Set state of the button
            StateMachine.SetState(state, this);
        }
    }
}
