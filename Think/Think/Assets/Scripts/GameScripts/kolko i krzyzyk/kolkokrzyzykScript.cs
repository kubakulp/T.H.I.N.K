using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kolkokrzyzykScript : MonoBehaviour
{
    public Text[] pola;

    public void ComputerMove()
    {
        //Pierwszy ruch//
        if (pola[4].text == "")
        {
            pola[4].text = "O";
            return;
        }
        else
        {
            if(pola[4].text == "X")
            {
                if (pola[7].text == "")
                {
                    pola[7].text = "O";
                    return;
                }
            }
        }

        for (int i = 0; i < 8; i = i + 3)
        {
            if (pola[i].text == pola[i + 1].text && pola[i].text != "")
            {
                if (pola[i + 2].text == "")
                {
                    pola[i + 2].text = "O";
                    return;
                }
            }
            if (pola[i + 1].text == pola[i + 2].text && pola[i + 1].text != "")
            {
                if (pola[i].text == "")
                {
                    pola[i].text = "O";
                    return;
                }
            }
            if (pola[i].text == pola[i + 2].text && pola[i].text != "")
            {
                if (pola[i + 1].text == "")
                {
                    pola[i + 1].text = "O";
                    return;
                }
            }
        }

        for(int j=0; j<3; j++)
        {
            if (pola[j].text == pola[j + 3].text && pola[j].text != "")
            {
                if (pola[j + 6].text == "")
                {
                    pola[j + 6].text = "O";
                    return;
                }
            }
            if (pola[j].text == pola[j + 6].text && pola[j].text != "")
            {
                if (pola[j + 3].text == "")
                {
                    pola[j + 3].text = "O";
                    return;
                }
            }
            if (pola[j + 3].text == pola[j + 6].text && pola[j + 3].text != "")
            {
                if (pola[j].text == "")
                {
                    pola[j].text = "O";
                    return;
                }
            }
        }

        if (pola[0].text == pola[4].text && pola[0].text != "")
        {
            if (pola[8].text == "")
            {
                pola[8].text = "O";
                return;
            }
        }
        if (pola[0].text == pola[8].text && pola[0].text != "")
        {
            if (pola[4].text == "")
            {
                pola[4].text = "O";
                return;
            }
        }
        if (pola[4].text == pola[8].text && pola[4].text != "")
        {
            if (pola[0].text == "")
            {
                pola[0].text = "O";
                return;
            }
        }

        if (pola[2].text == pola[4].text && pola[2].text != "")
        {
            if (pola[6].text == "")
            {
                pola[6].text = "O";
                return;
            }
        }
        if (pola[2].text == pola[6].text && pola[2].text != "")
        {
            if (pola[4].text == "")
            {
                pola[4].text = "O";
                return;
            }
        }
        if (pola[6].text == pola[4].text && pola[6].text != "")
        {
            if (pola[2].text == "")
            {
                pola[2].text = "O";
                return;
            }
        }

        int x = Random.Range(0, 8);
        while(pola[x].text != "")
        {
            x = Random.Range(0, 8); 
        }
        pola[x].text = "O";
        return;
    }

    public bool CheckWin()
    {
        if (pola[0].text == pola[1].text && pola[0].text == pola[2].text && pola[0].text == "X")
        {
            return true;
        }
        else
        if (pola[3].text == pola[4].text && pola[3].text == pola[5].text && pola[3].text == "X")
        {
            return true;
        }
        else
        if (pola[6].text == pola[7].text && pola[6].text == pola[8].text && pola[6].text == "X")
        {
            return true;
        }
        else
        if (pola[0].text == pola[3].text && pola[0].text == pola[6].text && pola[0].text == "X")
        {
            return true;
        }
        else
        if (pola[1].text == pola[4].text && pola[1].text == pola[7].text && pola[1].text == "X")
        {
            return true;
        }
        else
        if (pola[2].text == pola[5].text && pola[2].text == pola[8].text && pola[2].text == "X")
        {
            return true;
        }
        else
        if (pola[0].text == pola[4].text && pola[0].text == pola[8].text && pola[0].text == "X")
        {
            return true;
        }
        else
        if (pola[2].text == pola[4].text && pola[2].text == pola[6].text && pola[2].text == "X")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CheckComputerWin()
    {
        if (pola[0].text == pola[1].text && pola[0].text == pola[2].text && pola[0].text == "O")
        {
            return true;
        }
        else
        if (pola[3].text == pola[4].text && pola[3].text == pola[5].text && pola[3].text == "O")
        {
            return true;
        }
        else
        if (pola[6].text == pola[7].text && pola[6].text == pola[8].text && pola[6].text == "O")
        {
            return true;
        }
        else
        if (pola[0].text == pola[3].text && pola[0].text == pola[6].text && pola[0].text == "O")
        {
            return true;
        }
        else
        if (pola[1].text == pola[4].text && pola[1].text == pola[7].text && pola[1].text == "O")
        {
            return true;
        }
        else
        if (pola[2].text == pola[5].text && pola[2].text == pola[8].text && pola[2].text == "O")
        {
            return true;
        }
        else
        if (pola[0].text == pola[4].text && pola[0].text == pola[8].text && pola[0].text == "O")
        {
            return true;
        }
        else
        if (pola[2].text == pola[4].text && pola[2].text == pola[6].text && pola[2].text == "O")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool EndGame()
    {
        for(int i=0; i<9; i++)
        {
            if (pola[i].text == "")
            {
                return false;
            }
        }
        return true;
    }
}
