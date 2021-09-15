using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kolkokrzyzykButton : MonoBehaviour
{
    public Text text;
    public kolkokrzyzykScript kolkokrzyzykScript;
    public TextManagerScript textManagerScript;
    public Text answer;
    public void GetX()
    {
        if(text.text == "" && kolkokrzyzykScript.CheckWin() == false && kolkokrzyzykScript.CheckComputerWin() == false)
        {
            text.text = "X";
            if(kolkokrzyzykScript.CheckWin() == true)
            {
                answer.text = textManagerScript.answer;
                return;
            }

            if (kolkokrzyzykScript.EndGame() == true)
            {
                answer.text = "You Draw, try again";
                return;
            }

            kolkokrzyzykScript.ComputerMove();

            if (kolkokrzyzykScript.CheckComputerWin() == true)
            {
                answer.text = "You Lose, try again";
                return;
            }
        }
    }
}
