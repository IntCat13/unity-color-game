using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _ColorGame.Scripts.GamePlay.ButtonStates
{
    public interface IButtonState
    {
        // Set button color on state enter
        void OnEnter(Button button);
    }
}
