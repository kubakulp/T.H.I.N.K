using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSkoczek : MonoBehaviour
{
    private int[][] plansza;
    public Skoczek skoczek;
    public ButtonScript button;
    public CheckWin checkWin;

    public void ButtonClick()
    {
        if(button.IsVisited==false && ((button.gridX == skoczek.wspolrzednaX+2 && button.gridY == skoczek.wspolrzednaY + 1) || (button.gridX == skoczek.wspolrzednaX + 2 && button.gridY == skoczek.wspolrzednaY - 1) || (button.gridX == skoczek.wspolrzednaX - 2 && button.gridY == skoczek.wspolrzednaY - 1) || (button.gridX == skoczek.wspolrzednaX - 2 && button.gridY == skoczek.wspolrzednaY + 1) || (button.gridX == skoczek.wspolrzednaX + 1 && button.gridY == skoczek.wspolrzednaY + 2) || (button.gridX == skoczek.wspolrzednaX + 1 && button.gridY == skoczek.wspolrzednaY - 2) || (button.gridX == skoczek.wspolrzednaX - 1 && button.gridY == skoczek.wspolrzednaY - 2) || (button.gridX == skoczek.wspolrzednaX - 1 && button.gridY == skoczek.wspolrzednaY + 2)))
        {
            skoczek.transform.position = new Vector3(button.x, button.y, 0);
            button.przycisk.image.color = new Color32(0, 0, 0, 128);
            skoczek.wspolrzednaX = button.gridX;
            skoczek.wspolrzednaY = button.gridY;
            button.IsVisited = true;
            CheckWin();
        }
    }

    private void CheckWin()
    {
        for (int i = 0; i < checkWin.buttons.Length; i++)
        {
            if (checkWin.buttons[i].IsVisited == true)
            {

            }
            else
            {
                return;
            }
        }
        skoczek.answer.text = skoczek.textManagerScript.answer;
    }
}