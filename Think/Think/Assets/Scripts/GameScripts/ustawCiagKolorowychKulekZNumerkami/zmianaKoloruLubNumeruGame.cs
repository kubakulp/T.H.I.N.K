using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zmianaKoloruLubNumeruGame : MonoBehaviour
{
    public bool czyKolor = false;
    public bool czyLiczba = true;
    public Text answer;
    public TextManagerScript TextManagerScript;
    public zmianaKoloruLubNumeru[] przyciski;

    public void zmianaNaKolor()
    {
        czyKolor = true;
        czyLiczba = false;
    }

    public void zmianaNaLiczbe()
    {
        czyKolor = false;
        czyLiczba = true;
    }

    public void CheckWin()
    {
        bool win = true;

        foreach(zmianaKoloruLubNumeru z in przyciski)
        {
            if(z.obecnyKolor==z.wynikKolor && z.liczba==z.wynikLiczba)
            {

            }
            else
            {
                win = false;

            }
        }

        if(win==true)
        {
            answer.text = TextManagerScript.answer;
        }
    }
}
