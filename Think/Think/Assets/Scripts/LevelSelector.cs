using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] ButtonsA;
    public int Numer;
    // Start is called before the first frame update
    void Start()
    {
        int indexA = PlayerPrefs.GetInt("indeX", Numer);

        for (int i = 0; i < ButtonsA.Length; i++)
        {
            if (i + 1 > indexA)
            {
                ButtonsA[i].interactable = false;
            }
        }
    }
}
