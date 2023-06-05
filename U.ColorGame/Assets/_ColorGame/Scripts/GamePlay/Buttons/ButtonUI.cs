using UnityEngine;
using UnityEngine.UI;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    // This class is responsible for setting button color
    public class ButtonUI : MonoBehaviour
    {
        public void SetColor(Color color)
        {
            GetComponent<Image>().color = color;
        }
    }
}
