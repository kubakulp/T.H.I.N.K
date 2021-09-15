using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    public int levelNumber;
    public Text skipLevelText;

    public void ExitButton()
    {
        Application.Quit();
    }

    public void CurrentLevelButton()
    {
        int indexA = PlayerPrefs.GetInt("indeX", 1);
        if(indexA<=50)
        {
            SceneManager.LoadScene("Level" + indexA.ToString());
        }
        else
        {
            SceneManager.LoadScene("ThatsAll");
        }
    }

    public void ChooseLevelButton()
    {
        SceneManager.LoadScene("ChooseLevelScene");
    }

    public void ChooseHardLevelButton()
    {
        SceneManager.LoadScene("ChooseHardLevelScene");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LevelButton()
    {
        if(levelNumber<=50)
        {
            SceneManager.LoadScene("Level" + levelNumber);
        }
        else
        {
            SceneManager.LoadScene("ThatsAll");
        }
    }

    public void Level51Button()
    {
        SceneManager.LoadScene("Level51");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HintButton()
    {
        Ads ads = GetComponent<Ads>();
        if(skipLevelText.text == "Skip level")
        {
            ads.RewardedAd1();
        }
        else
        {
            ads.RewardedAd();
        }
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
