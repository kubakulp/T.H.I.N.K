using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedGreenGame : MonoBehaviour
{
    public Button[] buttons;
    public Button[] allButtons;
    public Text text;
    public Text finalText;

    public void ChangeColor()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].image.color == new Color32(255, 0, 0, 255))
            {
                buttons[i].image.color = new Color32(0, 255, 0, 255);
            }
            else
            {
                buttons[i].image.color = new Color32(255, 0, 0, 255);
            }
        }
    }
}
