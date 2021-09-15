using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obrazkiZKwadratowButtonScript : MonoBehaviour
{
    public Button button;
    public obrazkiZKwadratowTextScript X;
    public obrazkiZKwadratowTextScript Y;
    public bool IsRed = false;
    public checkWin check;

    public void OnButtonClick()
    {
        if(IsRed == false)
        {
            button.image.color = new Color32(255, 0, 0, 255);
            IsRed = true;
            X.StartValue--;
            Y.StartValue--;
            X.text.text = X.StartValue.ToString();
            Y.text.text = Y.StartValue.ToString();
        }
        else
        {
            button.image.color = new Color32(255, 255, 255, 255);
            IsRed = false;
            X.StartValue++;
            Y.StartValue++;
            X.text.text = X.StartValue.ToString();
            Y.text.text = Y.StartValue.ToString();
        }

        check.CheckWin();
    }
}
