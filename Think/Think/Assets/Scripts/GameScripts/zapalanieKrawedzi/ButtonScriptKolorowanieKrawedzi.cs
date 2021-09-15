using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScriptKolorowanieKrawedzi : MonoBehaviour
{
    public int value;
    public Image img;
    public GameScriptKolorowanieKrawedzi gameScript;
    public int clicked;
    public Text text;

    private void Start()
    {
        text.text = clicked.ToString();
    }

    public void OnClick()
    {
        if(clicked!=0)
        {
            if(gameScript.indexStart==-1)
            {
                gameScript.indexStart = value;
                clicked--;
                if(clicked==0)
                {
                    img.color = new Color32(0, 255, 0, 255);
                    text.text = "";
                }
                else
                {
                    text.text = clicked.ToString();
                }
            }
            else if(gameScript.indexEnd==-1)
            {
                gameScript.indexEnd = value;
                if (gameScript.KolorujKrawedz())
                {    
                    clicked--;
                    if (clicked == 0)
                    {
                        img.color = new Color32(0, 255, 0, 255);
                        text.text = "";
                    }
                    else
                    {
                        text.text = clicked.ToString();
                    }
                }
                else
                {
                    gameScript.indexEnd = -1;
                }
            }
            else
            {
                int x = gameScript.indexStart;
                gameScript.indexStart = gameScript.indexEnd;
                gameScript.indexEnd = value;
                if (!gameScript.KolorujKrawedz())
                {
                    gameScript.indexEnd = gameScript.indexStart;
                    gameScript.indexStart = x;
                }
                else
                {
                    clicked--;
                    if (clicked == 0)
                    {
                        img.color = new Color32(0, 255, 0, 255);
                        text.text = "";
                    }
                    else
                    {
                        text.text = clicked.ToString();
                    }
                }
            }
        }
        gameScript.CheckWin();
    }
}
