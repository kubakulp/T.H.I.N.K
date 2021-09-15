using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class klodkaLiterkiText : MonoBehaviour
{
    public Text text;
    public string[] literki;
    public int x = 0;
    public void ChangeTextUp()
    {
        x++;
        if (x%5==0)
        {
            text.text = literki[0];
        }
        if (x % 5 == 1)
        {
            text.text = literki[1];
        }
        if (x % 5 == 2)
        {
            text.text = literki[2];
        }
        if (x % 5 == 3)
        {
            text.text = literki[3];
        }
        if (x % 5 == 4)
        {
            text.text = literki[4];
        }
    }

    public void ChangeTextDown()
    {
        x--;
        if(x<0)
        {
            x = literki.Length-1;
        }
        if (x % 5 == 0)
        {
            text.text = literki[0];
        }
        if (x % 5 == 1)
        {
            text.text = literki[1];
        }
        if (x % 5 == 2)
        {
            text.text = literki[2];
        }
        if (x % 5 == 3)
        {
            text.text = literki[3];
        }
        if (x % 5 == 4)
        {
            text.text = literki[4];
        }
    }
}
