using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleScript : MonoBehaviour
{
    public CanvasScaler canvas;
    public Transform[] transforms;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<CanvasScaler>();
        float wynik = (float)(Screen.width / 3) / (float)(Screen.height/4);
        if(wynik>1)
        {
            canvas.matchWidthOrHeight = 1;
        }
        else
        {
            canvas.matchWidthOrHeight = wynik;
        }

        if(transforms!=null)
        {
            foreach (Transform t in transforms)
            {
                t.localScale = t.localScale * wynik * 4 / 3;
            }
        }
    }

    public float obliczSkale()
    {
        canvas = GetComponent<CanvasScaler>();
        float wynik = (float)(Screen.width / 3) / (float)(Screen.height / 4);
        if (wynik > 1)
        {
            wynik = 1;
        }

        return wynik * 4/3;
    }
}
