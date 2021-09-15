using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RememberColor : MonoBehaviour
{
    public Button button;
    public Button green;
    public Button red;
    public Button yellow;
    public Button blue;
    public int iloscZmianKoloru;
    public TextManagerScript answerr;
    public string answer;
    private int RandomowaLiczba;

    private void Start()
    {
        red.enabled = false;
        blue.enabled = false;
        yellow.enabled = false;
        green.enabled = false;
    }


    public void ChangeColor()
    {
        if (iloscZmianKoloru > 0)
        {
            RandomowaLiczba = Random.Range(0, 4) / 1;
            if (RandomowaLiczba == 0 && button.image.color != new Color32(255, 0, 0, 255))
            {
                button.image.color = new Color32(255, 0, 0, 255);
                answer = answer + "5";
                iloscZmianKoloru--;
            }
            else
            if (RandomowaLiczba == 1 && button.image.color != new Color32(0, 255, 0, 255))
            {
                button.image.color = new Color32(0, 255, 0, 255);
                answer = answer + "0";
                iloscZmianKoloru--;
            }
            else
            if (RandomowaLiczba == 2 && button.image.color != new Color32(0, 0, 255, 255))
            {
                button.image.color = new Color32(0, 0, 255, 255);
                answer = answer + "2";
                iloscZmianKoloru--;
            }
            else
            if (RandomowaLiczba == 3 && button.image.color != new Color32(255, 255, 0, 255))
            {
                button.image.color = new Color32(255, 255, 0, 255);
                answer = answer + "6";
                iloscZmianKoloru--;
            }
            else
            {
                ChangeColor();
            }
        }
        else
        {
            button.image.color = new Color32(255, 255, 255, 255);
            answerr.answer = answer;
            red.enabled = true;
            blue.enabled = true;
            green.enabled = true;
            yellow.enabled = true;
        }
    }
}