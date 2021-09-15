using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ads : MonoBehaviour
{
    public GameObject hintText;
    private ButtonsScript buttonScript;
    public Text skipLevelText;

    private void Start()
    {
        buttonScript = GetComponent<ButtonsScript>();
        hintText.SetActive(false);
    }

    public void StandardAd()
    {
        AdController.ShowStandardAd();
    }

    public void RewardedAd()
    {
        AdController.ShowRewardedAd(Success,Failed,Skipped);
    }

    public void RewardedAd1()
    {
        AdController.ShowRewardedAd(Success1, Failed, Skipped);
    }

    public void Success()
    {
        hintText.SetActive(true);
        skipLevelText.text = "Skip level";
    }

    public void Success1()
    {
        SceneManager.LoadScene("WinLevelScene" + buttonScript.levelNumber);
    }

    public void Failed()
    {

    }

    public void Skipped()
    {

    }
}
