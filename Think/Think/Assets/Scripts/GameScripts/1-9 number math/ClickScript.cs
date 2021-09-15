using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour
{
    public GameScript gameScript;
    public int iloscLiczb;
    public void Click()
    {
        if(GetComponentInChildren<Text>().text=="")
        {
            GetComponentInChildren<Text>().text = gameScript.GetNumber();
            gameScript.CheckWin();
        }
        else
        {
            gameScript.liczby[int.Parse(GetComponentInChildren<Text>().text)+iloscLiczb-1] = 1;
            GetComponentInChildren<Text>().text = "";
        }
    }
}
