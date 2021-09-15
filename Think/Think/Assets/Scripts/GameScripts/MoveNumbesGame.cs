using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveNumbesGame : MonoBehaviour
{
    public GameObject[] kwadraty;
    public int iloscKwadratow;
    public int[] wspolrzedneKoncoweX;
    public int[] wspolrzedneKoncoweY;
    public int[] wspolrzednePoczatkoweX;
    public int[] wspolrzednePoczatkoweY;
    private Vector3 poprzedniaPozycja;
    public Text answer;
    public TextManagerScript TextManagerScript;
    public ScaleScript scaleScript;
    private int wspolrzednePustegoX = 1;
    private int wspolrzednePustegoY = 4;

    public void CheckWin()
    {
        for (int i = 0; i < iloscKwadratow; i++)
        {
            if (wspolrzednePoczatkoweX[i]==wspolrzedneKoncoweX[i] && wspolrzednePoczatkoweY[i] == wspolrzedneKoncoweY[i])
            {

            }
            else
            {
                return;
            }
        }
        answer.text = TextManagerScript.answer;
    }

    public void MoveUp()
    {
        for(int i=0; i<iloscKwadratow; i++)
        {
            if(wspolrzednePustegoX==wspolrzednePoczatkoweX[i] && wspolrzednePustegoY==wspolrzednePoczatkoweY[i]+1)
            {
                kwadraty[i].transform.position = kwadraty[i].transform.position + new Vector3(0, 1*scaleScript.obliczSkale(), 0);
                wspolrzednePoczatkoweY[i]++;
                wspolrzednePustegoY--;
                CheckWin();
                return;
            }
        }
    }

    public void MoveDown()
    {
        for (int i = 0; i < iloscKwadratow; i++)
        {
            if (wspolrzednePustegoX == wspolrzednePoczatkoweX[i] && wspolrzednePustegoY == wspolrzednePoczatkoweY[i] - 1)
            {
                kwadraty[i].transform.position = kwadraty[i].transform.position + new Vector3(0, -1 * scaleScript.obliczSkale(), 0);
                wspolrzednePoczatkoweY[i]--;
                wspolrzednePustegoY++;
                CheckWin();
                return;
            }
        }
    }

    public void MoveLeft()
    {
        for (int i = 0; i < iloscKwadratow; i++)
        {
            if (wspolrzednePustegoX == wspolrzednePoczatkoweX[i] - 1 && wspolrzednePustegoY == wspolrzednePoczatkoweY[i])
            {
                kwadraty[i].transform.position = kwadraty[i].transform.position + new Vector3(-1 * scaleScript.obliczSkale(), 0, 0);
                wspolrzednePoczatkoweX[i]--;
                wspolrzednePustegoX++;
                CheckWin();
                return;
            }
        }
    }

    public void MoveRight()
    {
        for (int i = 0; i < iloscKwadratow; i++)
        {
            if (wspolrzednePustegoX == wspolrzednePoczatkoweX[i] + 1 && wspolrzednePustegoY == wspolrzednePoczatkoweY[i])
            {
                kwadraty[i].transform.position = kwadraty[i].transform.position + new Vector3(1 * scaleScript.obliczSkale(), 0, 0);
                wspolrzednePoczatkoweX[i]++;
                wspolrzednePustegoX--;
                CheckWin();
                return;
            }
        }
    }


}

