using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkWin : MonoBehaviour
{
    public Text answer;
    public Text[] score;
    private int x;
    public TextManagerScript textManagerScript;

    public void CheckWin()
    {
        x = 1;
        foreach(Text t in score)
        {
            if(t.text=="0")
            {

            }
            else
            {
                x = 0;
            }
        }

        if(x==1)
        {
            answer.text = textManagerScript.answer;
        }
    }
}
