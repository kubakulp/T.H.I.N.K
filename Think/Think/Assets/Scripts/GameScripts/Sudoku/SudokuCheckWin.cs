using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SudokuCheckWin : MonoBehaviour
{
    public Text answer;
    public SudokuScript[] SudokuScript;
    public TextManagerScript textManagerScript;

    public void CheckWin()
    {
        for(int x=0; x<81; x++)
        {
            if(SudokuScript[x].number==SudokuScript[x].goodNumber)
            {

            }
            else
            {
                return;
            }
        }
        answer.text = textManagerScript.answer;
    }
}
