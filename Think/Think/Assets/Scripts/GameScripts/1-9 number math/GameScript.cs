using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using System.Windows;

public class GameScript : MonoBehaviour
{
    public Text[] numerki;
    public int[] liczby;
    public Text answer;
    public TextManagerScript textManagerScript;
    public ClickScript clickScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void CheckWin()
    {
        if(clickScript.iloscLiczb==9)
        {
            if (numerki[0].text == "8")
            {
                if (numerki[1].text == "2")
                {
                    if (numerki[2].text == "4")
                    {
                        if (numerki[3].text == "5")
                        {
                            if (numerki[4].text == "9")
                            {
                                if (numerki[5].text == "3")
                                {
                                    if (numerki[6].text == "6")
                                    {
                                        if ((numerki[7].text == "1" && numerki[8].text == "7") || (numerki[7].text == "7" && numerki[8].text == "1"))
                                        {
                                            answer.text = textManagerScript.answer;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (clickScript.iloscLiczb == 7)
        {
            if (numerki[0].text == "3" && numerki[1].text == "2" && numerki[2].text == "6" && numerki[3].text == "5" && numerki[4].text == "1" && numerki[5].text == "7" && numerki[6].text == "4")
            {
                answer.text = textManagerScript.answer;
            }

            if (numerki[0].text == "2" && numerki[1].text == "3" && numerki[2].text == "6" && numerki[3].text == "1" && numerki[4].text == "5" && numerki[5].text == "4" && numerki[6].text == "7")
            {
                answer.text = textManagerScript.answer;
            }
        }
    }

    public string GetNumber()
    {
        for(int i=0; i<clickScript.iloscLiczb; i++)
        {
            if(liczby[i+clickScript.iloscLiczb] ==1)
            {
                liczby[i + clickScript.iloscLiczb] = 0;
                return liczby[i].ToString();
            }
        }
        return "";
    }
}
