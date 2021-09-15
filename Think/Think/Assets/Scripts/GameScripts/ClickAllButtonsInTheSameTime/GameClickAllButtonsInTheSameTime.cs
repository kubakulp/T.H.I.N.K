using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClickAllButtonsInTheSameTime : MonoBehaviour
{
    public ClickAllButtonsInTheSameTime[] buttons;
    public Text text;
    public TextManagerScript textManagerScript;

    private void Update()
    {
        CheckWin();
    }

    void CheckWin()
    {
        bool win = true;
        foreach(ClickAllButtonsInTheSameTime b in buttons)
        {
            if(b.buttonPressed==false)
            {
                win = false;
            }
        }

        if(win==true)
        {
            text.text = textManagerScript.answer;
        }
    }
}
