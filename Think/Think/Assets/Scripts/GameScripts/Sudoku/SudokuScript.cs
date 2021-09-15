using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SudokuScript : MonoBehaviour
{
    public int number = 0;
    public int goodNumber;
    public Text text;
    public bool IsStartNumber = false;
    public SudokuCheckWin sudokuCheckWin;

    public void Start()
    {
        if(IsStartNumber)
        {
            text.color = new Color32(255, 0, 0, 255);
        }

        if (number == 0)
        {
            text.text = "";
        }
        else
        {
            text.text = number.ToString();
        }
    }


    public void SudokuButton()
    {
        if(!IsStartNumber)
        {
            number++;
            if (number == 10)
            {
                number = 0;
            }
            if (number != 0)
            {
                text.text = number.ToString();
            }
            else
            {
                text.text = "";
            }
        }
        sudokuCheckWin.CheckWin();
    }
}
