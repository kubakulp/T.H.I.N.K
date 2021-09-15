using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWinLiterki : MonoBehaviour
{
    public Text[] texts;
    private int iloscA=0;
    private int iloscB=0;
    private int iloscC=0;
    private int iloscD=0;
    private int iloscE=0;
    public Text text;
    public TextManagerScript textManagerScript;

    public void CheckWin()
    {
        iloscA = 0;
        iloscB = 0;
        iloscC = 0;
        iloscD = 0;
        iloscE = 0;
        for(int i=0; i<texts.Length; i++)
        {
            if(texts[i].text=="A")
            {
                iloscA++;
            }
            if (texts[i].text == "B")
            {
                iloscB++;
            }
            if (texts[i].text == "C")
            {
                iloscC++;
            }
            if (texts[i].text == "D")
            {
                iloscD++;
            }
            if (texts[i].text == "E")
            {
                iloscE++;
            }
        }
        if(iloscA==5&&iloscB==5&&iloscC==5&&iloscD==5&&iloscE==5)
        {
            //KOLUMNY//
            iloscA = 0;
            iloscB = 0;
            iloscC = 0;
            iloscD = 0;
            iloscE = 0;
            for(int j=0; j<5; j++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (texts[x+j*5].text == "A")
                    {
                        iloscA++;
                    }
                    if (texts[x+j*5].text == "B")
                    {
                        iloscB++;
                    }
                    if (texts[x+j*5].text == "C")
                    {
                        iloscC++;
                    }
                    if (texts[x+j*5].text == "D")
                    {
                        iloscD++;
                    }
                    if (texts[x+j*5].text == "E")
                    {
                        iloscE++;
                    }
                }
                if (iloscA == j + 1 && iloscB == j + 1 && iloscC == j + 1 && iloscD == j + 1 && iloscE == j + 1)
                {

                }
                else
                {
                    return;
                }
            }
            //WIERSZE//
            iloscA = 0;
            iloscB = 0;
            iloscC = 0;
            iloscD = 0;
            iloscE = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (texts[j + x * 5].text == "A")
                    {
                        iloscA++;
                    }
                    if (texts[j + x * 5].text == "B")
                    {
                        iloscB++;
                    }
                    if (texts[j + x * 5].text == "C")
                    {
                        iloscC++;
                    }
                    if (texts[j + x * 5].text == "D")
                    {
                        iloscD++;
                    }
                    if (texts[j + x * 5].text == "E")
                    {
                        iloscE++;
                    }
                }
                if (iloscA == j + 1 && iloscB == j + 1 && iloscC == j + 1 && iloscD == j + 1 && iloscE == j + 1)
                {

                }
                else
                {
                    return;
                }
            }
            //PRZEKATNE//
            if(texts[0].text != texts[6].text && texts[0].text != texts[12].text && texts[0].text != texts[18].text && texts[0].text != texts[24].text)
            {

            }
            else
            {
                return;
            }
            if (texts[1].text != texts[5].text && texts[1].text != texts[7].text && texts[1].text != texts[13].text && texts[1].text != texts[19].text)
            {

            }
            else
            {
                return;
            }
            if (texts[2].text != texts[6].text && texts[2].text != texts[8].text && texts[2].text != texts[10].text && texts[2].text != texts[14].text)
            {

            }
            else
            {
                return;
            }
            if (texts[3].text != texts[7].text && texts[3].text != texts[9].text && texts[3].text != texts[11].text && texts[3].text != texts[15].text)
            {

            }
            else
            {
                return;
            }
            if (texts[4].text != texts[8].text && texts[4].text != texts[12].text && texts[4].text != texts[16].text && texts[4].text != texts[20].text)
            {

            }
            else
            {
                return;
            }
            if (texts[5].text != texts[11].text && texts[5].text != texts[17].text && texts[5].text != texts[23].text)
            {

            }
            else
            {
                return;
            }
            if (texts[6].text != texts[12].text && texts[6].text != texts[18].text && texts[6].text != texts[24].text && texts[6].text != texts[10].text)
            {
                
            }
            else
            {
                return;
            }
            if (texts[7].text != texts[11].text && texts[7].text != texts[13].text && texts[7].text != texts[15].text && texts[7].text != texts[19].text)
            {

            }
            else
            {
                return;
            }
            if (texts[8].text != texts[12].text && texts[8].text != texts[14].text && texts[8].text != texts[16].text && texts[8].text != texts[20].text)
            {

            }
            else
            {
                return;
            }
            if (texts[9].text != texts[13].text && texts[9].text != texts[17].text && texts[9].text != texts[21].text)
            {

            }
            else
            {
                return;
            }
            if (texts[10].text != texts[16].text && texts[10].text != texts[22].text)
            {

            }
            else
            {
                return;
            }
            if (texts[11].text != texts[15].text && texts[11].text != texts[17].text && texts[11].text != texts[23].text)
            {

            }
            else
            {
                return;
            }
            if (texts[12].text != texts[16].text && texts[12].text != texts[18].text && texts[12].text != texts[20].text && texts[12].text != texts[24].text)
            {

            }
            else
            {
                return;
            }
            if (texts[13].text != texts[17].text && texts[13].text != texts[19].text && texts[13].text != texts[21].text)
            {

            }
            else
            {
                return;
            }
            if (texts[14].text != texts[18].text && texts[14].text != texts[22].text)
            {

            }
            else
            {
                return;
            }
            if (texts[15].text != texts[21].text)
            {

            }
            else
            {
                return;
            }
            if (texts[16].text != texts[20].text && texts[16].text != texts[22].text)
            {

            }
            else
            {
                return;
            }
            if (texts[17].text != texts[21].text && texts[17].text != texts[23].text)
            {

            }
            else
            {
                return;
            }
            if (texts[18].text != texts[22].text && texts[18].text != texts[24].text)
            {

            }
            else
            {
                return;
            }
            if (texts[19].text != texts[23].text)
            {

            }
            else
            {
                return;
            }
        }
        else
        {
            return;
        }
        text.text = textManagerScript.answer;
    }
}
