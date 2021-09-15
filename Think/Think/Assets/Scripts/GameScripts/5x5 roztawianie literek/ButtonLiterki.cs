using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLiterki : MonoBehaviour
{
    public Text text;
    private int x = 0;
    public CheckWinLiterki CheckWinLiterki;

    public void ChangeLetter()
    {
        x++;
        if(x % 6 == 0)
        {
            text.text = "";
        }
        if (x % 6 == 1)
        {
            text.text = "A";
        }
        if (x % 6 == 2)
        {
            text.text = "B";
        }
        if (x % 6 == 3)
        {
            text.text = "C";
        }
        if (x % 6 == 4)
        {
            text.text = "D";
        }
        if (x % 6 == 5)
        {
            text.text = "E";
        }
        CheckWinLiterki.CheckWin();
    }
}
