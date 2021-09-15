using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script25Game : MonoBehaviour
{
    private int x;
    public Text answer;
    public Text lastMove;
    public Text WinOrLoseText;
    public TextManagerScript TextManagerScript;
    public Button[] buttons;

    public void Start()
    {
        x = 25;
    }

    public void ChangeNumberButton1()
    {
        x = x - 1;
        answer.text = x.ToString();

        if (x < 0)
        {
            x = 0;
            answer.text = x.ToString();
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
        }
        else
        if (x == 0)
        {
            WinOrLoseText.text = "You Win";
            lastMove.text = TextManagerScript.answer;
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
            return;
        }
        else
        if (x % 4 == 1)
        {
            lastMove.text = "the last move of the opponent is: -1";
            x = x - 1;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 2)
        {
            lastMove.text = "the last move of the opponent is: -2";
            x = x - 2;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 3)
        {
            lastMove.text = "the last move of the opponent is: -3";
            x = x - 3;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        {
            int y = Random.Range(1, 3);
            lastMove.text = "the last move of the opponent is: -" + y;
            x = x - y;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
    }

    public void ChangeNumberButton2()
    {
        x = x - 2;
        answer.text = x.ToString();

        if (x < 0)
        {
            x = 0;
            answer.text = x.ToString();
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
        }
        else
        if (x == 0)
        {
            WinOrLoseText.text = "You Win";
            lastMove.text = TextManagerScript.answer;
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
            return;
        }
        else
        if (x % 4 == 1)
        {
            lastMove.text = "the last move of the opponent is: -1";
            x = x - 1;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 2)
        {
            lastMove.text = "the last move of the opponent is: -2";
            x = x - 2;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 3)
        {
            lastMove.text = "the last move of the opponent is: -3";
            x = x - 3;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        {
            int y = Random.Range(1, 3);
            lastMove.text = "the last move of the opponent is: -" + y;
            x = x - y;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
    }

    public void ChangeNumberButton3()
    {
        x = x - 3;
        answer.text = x.ToString();

        if (x < 0)
        {
            x = 0;
            answer.text = x.ToString();
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
        }
        else
        if (x == 0)
        {
            WinOrLoseText.text = "You Win";
            lastMove.text = TextManagerScript.answer;
            for (int i = 0; i < 3; i++)
            {
                buttons[i].enabled = false;
            }
            return;
        }
        else
        if (x % 4 == 1)
        {
            lastMove.text = "the last move of the opponent is: -1";
            x = x - 1;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 2)
        {
            lastMove.text = "the last move of the opponent is: -2";
            x = x - 2;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        if (x % 4 == 3)
        {
            lastMove.text = "the last move of the opponent is: -3";
            x = x - 3;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
        else
        {
            int y = Random.Range(1, 3);
            lastMove.text = "the last move of the opponent is: -" + y;
            x = x - y;
            answer.text = x.ToString();
            if (x == 0)
            {
                WinOrLoseText.text = "You Lost";
                return;
            }
        }
    }
}
