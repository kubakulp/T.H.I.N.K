using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManagerScript : MonoBehaviour
{
    public Text finalText;
    public Text wrongAnswerText;
    public string answer;
    public LevelScript LevelScript;
    public static float wrongAnswerTime = 0;

    public void ClearText()
    {
        finalText.text = "";
    }

    public void CheckText()
    {
        if(finalText.text == answer)
        {
            if(LevelScript.LevelNumber+1 > PlayerPrefs.GetInt("indeX"))
            {
                PlayerPrefs.SetInt("indeX", LevelScript.LevelNumber + 1);
            }

            SceneManager.LoadScene("WinLevelScene" + (LevelScript.LevelNumber));
        }
        else
        {
            wrongAnswerText.text = "Wrong Answer";
            wrongAnswerTime = 1;
        }
    }

    void Update()
    {
        wrongAnswerTime -= Time.deltaTime;
        if(wrongAnswerTime<0)
        {
            wrongAnswerText.text = "";
        }
    }
}
