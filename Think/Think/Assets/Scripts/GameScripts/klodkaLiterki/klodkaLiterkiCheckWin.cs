using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class klodkaLiterkiCheckWin : MonoBehaviour
{
    public Text text;
    public TextManagerScript TextManagerScript;
    public Text[] literki;
    public string[] odpowiedz;

    public void Update()
    { 
        if(literki[0].text == odpowiedz[0] && literki[1].text == odpowiedz[1] && literki[2].text == odpowiedz[2] && literki[3].text == odpowiedz[3] && literki[4].text == odpowiedz[4])
        {
            text.text = TextManagerScript.answer;
        }
    }
}
