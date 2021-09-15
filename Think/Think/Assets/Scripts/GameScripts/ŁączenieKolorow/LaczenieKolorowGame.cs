using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaczenieKolorowGame : MonoBehaviour
{
    public int numerKoloru;
    private Button button;
    public LaczenieKolorowGameScript game;

    private void Start()
    {
        button = GetComponent<Button>();
        numerKoloru = 0;
    }

    public void ChangeColor()
    {
        ColorBlock colors = button.colors;

        numerKoloru++;
        if(numerKoloru>=10)
        {
            numerKoloru = 0;
        }

        if(numerKoloru==0)
        {
            colors.normalColor = new Color32(255, 255, 255, 255);
            colors.highlightedColor = new Color32(255, 255, 255, 255);
            colors.pressedColor = new Color32(255, 255, 255, 255);
            colors.selectedColor = new Color32(255, 255, 255, 255);
        }
        else if(numerKoloru==4)
        {
            colors.normalColor = new Color32(255, 255, 0, 255);
            colors.highlightedColor = new Color32(255, 255, 0, 255);
            colors.pressedColor = new Color32(255, 255, 0, 255);
            colors.selectedColor = new Color32(255, 255, 0, 255);
        }
        else if(numerKoloru==5)
        {
            colors.normalColor = new Color32(255, 0, 255, 255);
            colors.highlightedColor = new Color32(255, 0, 255, 255);
            colors.pressedColor = new Color32(255, 0, 255, 255);
            colors.selectedColor = new Color32(255, 0, 255, 255);
        }
        else if(numerKoloru==6)
        {
            colors.normalColor = new Color32(0, 255, 255, 255);
            colors.highlightedColor = new Color32(0, 255, 255, 255);
            colors.pressedColor = new Color32(0, 255, 255, 255);
            colors.selectedColor = new Color32(0, 255, 255, 255);
        }
        else if(numerKoloru==7)
        {
            colors.normalColor = new Color32(128, 128, 128, 255);
            colors.highlightedColor = new Color32(128, 128, 128, 255);
            colors.pressedColor = new Color32(128, 128, 128, 255);
            colors.selectedColor = new Color32(128, 128, 128, 255);
        }
        else if (numerKoloru == 1)
        {
            colors.normalColor = new Color32(255, 0, 0, 255);
            colors.highlightedColor = new Color32(255, 0, 0, 255);
            colors.pressedColor = new Color32(255, 0, 0, 255);
            colors.selectedColor = new Color32(255, 0, 0, 255);
        }
        else if (numerKoloru == 2)
        {
            colors.normalColor = new Color32(0, 255, 0, 255);
            colors.highlightedColor = new Color32(0, 255, 0, 255);
            colors.pressedColor = new Color32(0, 255, 0, 255);
            colors.selectedColor = new Color32(0, 255, 0, 255);
        }
        else if (numerKoloru == 3)
        {
            colors.normalColor = new Color32(0, 0, 255, 255);
            colors.highlightedColor = new Color32(0, 0, 255, 255);
            colors.pressedColor = new Color32(0, 0, 255, 255);
            colors.selectedColor = new Color32(0, 0, 255, 255);
        }
        else if (numerKoloru == 8)
        {
            colors.normalColor = new Color32(255, 128, 0, 255);
            colors.highlightedColor = new Color32(255, 128, 0, 255);
            colors.pressedColor = new Color32(255, 128, 0, 255);
            colors.selectedColor = new Color32(255, 128, 0, 255);
        }
        else if (numerKoloru == 9)
        {
            colors.normalColor = new Color32(128, 0, 255, 255);
            colors.highlightedColor = new Color32(128, 0, 255, 255);
            colors.pressedColor = new Color32(128, 0, 255, 255);
            colors.selectedColor = new Color32(128, 0, 255, 255);
        }

        button.colors = colors;
        game.CheckWin();
    }
}
