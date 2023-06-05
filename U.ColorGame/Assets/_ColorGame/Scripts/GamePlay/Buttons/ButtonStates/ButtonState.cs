using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    // This class is responsible for storing button state
    [CreateAssetMenu(fileName = "Button State", menuName = "Button States/New Button State")]
    public class ButtonState : ScriptableObject, IButtonState
    {
        [SerializeField]private Color _stateColor = Color.gray;
    
        // Set button color to gray
        public void OnEnter(GameButton button)
        {
            button.UI.SetColor(_stateColor);
        }
        
        public Color GetColor() 
            => _stateColor;

    }
}
