using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaczenieKolorowGameScript : MonoBehaviour
{
    public LaczenieKolorowGame[] laczenieKolorowGames;
    public TextManagerScript textManagerScript;
    public Text answer;

    public void CheckWin()
    {
        if(laczenieKolorowGames[0].numerKoloru==1 && laczenieKolorowGames[1].numerKoloru == 3 && laczenieKolorowGames[2].numerKoloru == 2 && laczenieKolorowGames[3].numerKoloru == 8 && laczenieKolorowGames[4].numerKoloru == 9)
        {
            answer.text = textManagerScript.answer;
        }
    }
}
