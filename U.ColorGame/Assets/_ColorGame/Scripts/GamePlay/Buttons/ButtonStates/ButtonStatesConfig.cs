using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    // This class contains all the states for the button
    [CreateAssetMenu(fileName = "Button State", menuName = "Button States/New Button States Config")]
    public class ButtonStatesConfig : ScriptableObject, IRandomButtonState
    {
        public ButtonState NullState;
        public ButtonState RedState;
        public ButtonState GreenState;
        public ButtonState BlueState;
        public ButtonState YellowState;
        public ButtonState OrangeState;
        public ButtonState PurpleState;
        public ButtonState CyanState;
        public ButtonState PinkState;
        public ButtonState BrownState;
        public ButtonState WhiteState;
        public ButtonState BlackState;
        private int NumberOfStates = 12;
        public ButtonState GetRandomState(ButtonState previousState)
        {
            ButtonState randomState = GetRandomState();
            while (randomState == previousState)
                randomState = GetRandomState();

            return randomState;
        }
        
        public ButtonState GetRandomState()
        {
            var randomState = Random.Range(1, NumberOfStates);
            switch (randomState)
            {
                case 1:
                    return RedState;
                case 2:
                    return GreenState;
                case 3:
                    return BlueState;
                case 4:
                    return YellowState;
                case 5:
                    return OrangeState;
                case 6:
                    return PurpleState;
                case 7:
                    return CyanState;
                case 8:
                    return PinkState;
                case 9:
                    return BrownState;
                case 10:
                    return WhiteState;
                case 11:
                    return BlackState;
                default:
                    return NullState;
            }
        }
    }
}
