using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump2SquaresGame : MonoBehaviour
{
    public GameObject kulka;
    private int x=1;
    public SpriteRenderer[] kwadraty;
    public Text answer;
    public TextManagerScript TextManagerScript;
    public ScaleScript scaleScript;
    private int startedX = 1;
    private int startedY = 4;

    private void Update()
    {
        CheckWin();    
    }

    public void MoveUp()
    {
        if(startedY+x<=4)
        {
            kulka.transform.position = kulka.transform.position + new Vector3(0, x * scaleScript.obliczSkale(), 0);
            startedY = startedY + x;
            x++;
            for (int i = 0; i < kwadraty.Length; i++)
            {
                if (kwadraty[i].transform.position == kulka.transform.position)
                {
                    if (kwadraty[i].color == new Color32(255, 0, 0, 255))
                    {
                        kwadraty[i].color = new Color32(0, 255, 0, 255);
                    }
                    else
                        kwadraty[i].color = new Color32(255, 0, 0, 255);
                }
            }

            if (x > 2)
            {
                x = 1;
            }
        }
    }

    public void MoveDown()
    {
        if(startedY - x >=1)
        {
            kulka.transform.position = kulka.transform.position + new Vector3(0, -x * scaleScript.obliczSkale(), 0);
            startedY = startedY - x;
            x++;
            for (int i = 0; i < kwadraty.Length; i++)
            {
                if (kwadraty[i].transform.position == kulka.transform.position)
                {
                    if (kwadraty[i].color == new Color32(255, 0, 0, 255))
                    {
                        kwadraty[i].color = new Color32(0, 255, 0, 255);
                    }
                    else
                        kwadraty[i].color = new Color32(255, 0, 0, 255);
                }
            }

            if (x > 2)
            {
                x = 1;
            }
        }
    }

    public void MoveLeft()
    { 
        if(startedX - x >=1)
        {
            kulka.transform.position = kulka.transform.position + new Vector3(-x * scaleScript.obliczSkale(), 0, 0);
            startedX = startedX - x;
            x++;
            for (int i = 0; i < kwadraty.Length; i++)
            {
                if (kwadraty[i].transform.position == kulka.transform.position)
                {
                    if (kwadraty[i].color == new Color32(255, 0, 0, 255))
                    {
                        kwadraty[i].color = new Color32(0, 255, 0, 255);
                    }
                    else
                        kwadraty[i].color = new Color32(255, 0, 0, 255);
                }
            }

            if (x > 2)
            {
                x = 1;
            }
        }
    }

    public void MoveRight()
    {
        if(startedX+x<=5)
        {
            kulka.transform.position = kulka.transform.position + new Vector3(x * scaleScript.obliczSkale(), 0, 0);
            startedX = startedX + x;
            x++;
            for (int i = 0; i < kwadraty.Length; i++)
            {
                if (kwadraty[i].transform.position == kulka.transform.position)
                {
                    if (kwadraty[i].color == new Color32(255, 0, 0, 255))
                    {
                        kwadraty[i].color = new Color32(0, 255, 0, 255);
                    }
                    else
                        kwadraty[i].color = new Color32(255, 0, 0, 255);
                }
            }

            if (x > 2)
            {
                x = 1;
            }
        }
    }

    public void CheckWin()
    {
        for (int i = 0; i < kwadraty.Length; i++)
        {
            if (kwadraty[i].color != new Color32(0, 255, 0, 255))
            {
                return;
            }
        }
        answer.text = TextManagerScript.answer;
    }
}
