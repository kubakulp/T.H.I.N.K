using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberScript : MonoBehaviour
{
    public int Value;
    public Text finalText;

    public void WriteValue()
    {
        finalText.text = finalText.text + Value;
    }
}
