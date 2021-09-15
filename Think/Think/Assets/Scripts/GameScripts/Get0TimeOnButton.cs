using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get0TimeOnButton : MonoBehaviour
{
    private float StartTime1 = 5;
    private float StartTime2 = 3;
    private float StartTime3 = 1;
    private int x1 = 1;
    private int x2 = 1;
    private int x3 = 1;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text answer;
    public TextManagerScript TextManagerScript;

    private void Start()
    {
        text1.text = StartTime1.ToString();
        text2.text = StartTime2.ToString();
        text3.text = StartTime3.ToString();
    }

    private void Update()
    {
        if(x1%2==0)
        {
            StartTime1 = StartTime1 - Time.deltaTime;
            text1.text = Mathf.Round(StartTime1).ToString();
        }

        if (x2 % 2 == 0)
        {
            StartTime2 = StartTime2 - Time.deltaTime;
            text2.text = StartTime2.ToString("F1");
        }

        if (x3 % 2 == 0)
        {
            StartTime3 = StartTime3 - Time.deltaTime;
            text3.text = StartTime3.ToString("F2");
        }
 
    }

    public void Button1()
    { 
        if(StartTime1<0)
        { 
            StartTime1 = 5;
        }
        x1++;
        CheckWin();
    }

    public void Button2()
    {
        if (StartTime2 < 0)
        {
            StartTime2 = 3;
        }
        x2++;
        CheckWin();
    }

    public void Button3()
    {
        if (StartTime3 < 0)
        {
            StartTime3 = 1;
        }
        x3++;
        CheckWin();
    }

    private void CheckWin()
    {
        if (text1.text == "0" && text2.text == "0.0" && text3.text == "0.00")
        {
            answer.text = TextManagerScript.answer;
        }
    }
}
