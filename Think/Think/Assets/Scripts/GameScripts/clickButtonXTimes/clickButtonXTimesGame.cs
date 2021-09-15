using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickButtonXTimesGame : MonoBehaviour
{
    public int LevelNumber;
    private int clickNumber = 0;
    public TextManagerScript textManagerScript;
    public Text answer;

    public void clickAnotherButton()
    {
        clickNumber = 0;
    }

    public void clickAnswerButton()
    {
        clickNumber++;
        if(clickNumber==LevelNumber)
        {
            Win();
        }
    }

    public void Win()
    {
        answer.text = textManagerScript.answer;
    }

}
