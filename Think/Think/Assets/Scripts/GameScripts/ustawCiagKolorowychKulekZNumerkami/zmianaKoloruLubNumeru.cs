using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zmianaKoloruLubNumeru : MonoBehaviour
{
    private Button button;
    private Text text;

    public int obecnyKolor;
    public int liczba;
    public int liczbaMaksymalna;
    public zmianaKoloruLubNumeruGame game;
    public int wynikLiczba;
    public int wynikKolor;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text = GetComponentInChildren<Text>();
        obecnyKolor = 0;
    }

    public void onButtonClick()
    {
        if (game.czyKolor == true)
        {
            if (obecnyKolor + 1 != liczbaMaksymalna)
            {
                obecnyKolor++;
            }
            else
            {
                obecnyKolor = 0;
            }

            ColorBlock colors = button.colors;
            if (obecnyKolor == 0)
            {
                colors.normalColor = new Color32(255, 255, 255, 255);
                colors.highlightedColor = new Color32(255, 255, 255, 255);
                colors.pressedColor = new Color32(255, 255, 255, 255);
                colors.selectedColor = new Color32(255, 255, 255, 255);
            }
            else if (obecnyKolor == 1)
            {
                colors.normalColor = new Color32(255, 255, 0, 255);
                colors.highlightedColor = new Color32(255, 255, 0, 255);
                colors.pressedColor = new Color32(255, 255, 0, 255);
                colors.selectedColor = new Color32(255, 255, 0, 255);
            }
            else if(obecnyKolor==2)
            {
                colors.normalColor = new Color32(255, 0, 255, 255);
                colors.highlightedColor = new Color32(255, 0, 255, 255);
                colors.pressedColor = new Color32(255, 0, 255, 255);
                colors.selectedColor = new Color32(255, 0, 255, 255);
            }
            else if(obecnyKolor==3)
            {
                colors.normalColor = new Color32(0, 255, 255, 255);
                colors.highlightedColor = new Color32(0, 255, 255, 255);
                colors.pressedColor = new Color32(0, 255, 255, 255);
                colors.selectedColor = new Color32(0, 255, 255, 255);
            }
            else if(obecnyKolor==4)
            {
                colors.normalColor = new Color32(128, 128, 128, 255);
                colors.highlightedColor = new Color32(128, 128, 128, 255);
                colors.pressedColor = new Color32(128, 128, 128, 255);
                colors.selectedColor = new Color32(128, 128, 128, 255);
            }

            button.colors = colors;
        }
        else if (game.czyLiczba == true)
        {
            if (liczba + 1 != liczbaMaksymalna)
            {
                liczba++;
                text.text = liczba.ToString();
            }
            else
            {
                liczba = 0;
                text.text = liczba.ToString();
            }
        }

        game.CheckWin();
    }
}
