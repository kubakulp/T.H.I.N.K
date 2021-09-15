using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsAllGreen : MonoBehaviour
{
    public Button[] allButtons;
    public Text text;
    public string Answer;
    void Update()
    {
        IsAllGreenn();
    }

    public void IsAllGreenn()
    {
        int a = 0;
        for (int i = 0; i < allButtons.Length; i++)
        {
            if (allButtons[i].image.color != new Color32(255, 0, 0, 255))
            {
                a++;
            }
        }

        if(a == allButtons.Length)
        {
            text.text = Answer;
        }
    }
}
