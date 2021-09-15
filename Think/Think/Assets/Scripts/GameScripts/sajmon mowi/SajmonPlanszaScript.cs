using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SajmonPlanszaScript : MonoBehaviour
{
    public int dlugoscKolejki;
    public int obecnaDlugoscKolejki = 1;
    public int pomocnicza = 0;
    public int pomocniczaDoPokazywaniaPrzycisku = 0;
    public int[] kolejka;
    public Button[] buttons;
    public TextManagerScript textManagerScript;
    public Text text;

    private void Start()
    {
        UstawKolejke();
        PokazKolejke();
    }

    private void Update()
    {

    }

    public void UstawKolejke()
    {
        for(int x=0; x<dlugoscKolejki; x++)
        {
            kolejka[x] = Random.Range(1, 10);
        }
    }

    public void EndGame()
    {
        text.text = textManagerScript.answer;
    }

    public void PokazKolejke()
    {
        buttons[pomocniczaDoPokazywaniaPrzycisku].image.color = new Color32(0, 0, 128, 255);
        pomocniczaDoPokazywaniaPrzycisku++;
    }
}
