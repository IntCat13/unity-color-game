using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.ButtonStates
{
    // This class contains all the states for the button
    [CreateAssetMenu(fileName = "Button State", menuName = "Button States/New Button States Config")]
    public class ButtonStatesConfig : ScriptableObject
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
        public int NumberOfStates = 12;
    }
}
