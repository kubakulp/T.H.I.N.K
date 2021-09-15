using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLevel : MonoBehaviour
{
    public Text ClickButtonText;
    public static float wrongAnswerTime = 4;

    public void ClickButton()
    {
        ClickButtonText.text = "DON'T CLICK";
        wrongAnswerTime = 4;
    }

    void Update()
    {
        wrongAnswerTime -= Time.deltaTime;
        if (wrongAnswerTime < 0 && ClickButtonText.text == "DON'T CLICK")
        {
            ClickButtonText.text = "222222";
        }
    }
}
