using UnityEngine;
using UnityEngine.UI;

namespace _ColorGame.Scripts.GamePlay.Buttons
{
    public class ButtonUI : MonoBehaviour
    {
        public void SetColor(Color color)
        {
            GetComponent<Image>().color = color;
        }
    }
}
