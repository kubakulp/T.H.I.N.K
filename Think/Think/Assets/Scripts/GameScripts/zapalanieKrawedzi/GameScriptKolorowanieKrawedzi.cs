using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScriptKolorowanieKrawedzi : MonoBehaviour
{
    public int indexStart = -1;
    public int indexEnd = -1;
    public KrawedzScriptKolorowanieKrawedzi[] krawedzie;
    public ButtonScriptKolorowanieKrawedzi[] przyciski;
    public Text answer;
    public TextManagerScript textManagerScript;

    public bool KolorujKrawedz()
    {
        if(indexEnd==-1)
        {
            foreach (KrawedzScriptKolorowanieKrawedzi k in krawedzie)
            {
                if (k.index1 == indexStart)
                {
                    k.img.color = new Color32(0, 255, 0, 255);
                    k.colored = true;
                    return true;
                }
            }
            return false;
        }

        foreach(KrawedzScriptKolorowanieKrawedzi k in krawedzie)
        {
            if(((k.index1==indexStart && k.index2==indexEnd) || (k.index1 == indexEnd && k.index2 == indexStart)) && k.colored==false)
            {
                k.img.color = new Color32(0, 255, 0, 255);
                k.colored = true;
                return true;
            }
        }
        return false;
    }

    public void CheckWin()
    {
        int flag = 0;

        foreach (KrawedzScriptKolorowanieKrawedzi k in krawedzie)
        {
            if(k.colored==false)
            {
                flag = 1;
            }
        }

        foreach (ButtonScriptKolorowanieKrawedzi p in przyciski)
        {
            if (p.clicked != 0)
            {
                flag = 1;
            }
        }

        if (flag==0)
        {
            answer.text = textManagerScript.answer;
        }
    }
}
