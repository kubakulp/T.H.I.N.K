using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obrazkiZKwadratowTextScript : MonoBehaviour
{
    public Text text;
    public int StartValue;

    private void Start()
    {
        text.text = StartValue.ToString();
    }
}
