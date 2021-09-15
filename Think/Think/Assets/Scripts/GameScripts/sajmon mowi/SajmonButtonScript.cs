using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SajmonButtonScript : MonoBehaviour
{
    public int numerPrzycisku;
    public SajmonPlanszaScript sajmonPlanszaScript;

    public void OnButtonClick()
    {
        if (numerPrzycisku == sajmonPlanszaScript.kolejka[sajmonPlanszaScript.pomocnicza])
        {
            sajmonPlanszaScript.pomocnicza++;
            if (sajmonPlanszaScript.pomocnicza == sajmonPlanszaScript.obecnaDlugoscKolejki)
            {
                sajmonPlanszaScript.pomocnicza = 0;
                sajmonPlanszaScript.obecnaDlugoscKolejki++;
                if (sajmonPlanszaScript.obecnaDlugoscKolejki > sajmonPlanszaScript.dlugoscKolejki)
                {
                    sajmonPlanszaScript.EndGame();
                }
                else
                {
                    sajmonPlanszaScript.PokazKolejke();
                }
            }
        }
        else
        {
            sajmonPlanszaScript.obecnaDlugoscKolejki = 1;
            sajmonPlanszaScript.pomocniczaDoPokazywaniaPrzycisku = 0;
            sajmonPlanszaScript.pomocnicza = 0;
            sajmonPlanszaScript.UstawKolejke();
            sajmonPlanszaScript.PokazKolejke();
        }
    }
}
