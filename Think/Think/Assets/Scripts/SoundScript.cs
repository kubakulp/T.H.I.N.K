using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
    private bool isMuted = false;
    public GameObject mutedOn;
    public GameObject muteOff;
    private AudioSource audio = new AudioSource();

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        if(PlayerPrefs.GetInt("audio")==1)
        {
            isMuted = true;
        }
        else
        {
            isMuted = false;
        }
        MuteSound();

        Scene scene = SceneManager.GetActiveScene();

        int numMusicPlayers = FindObjectsOfType<AudioSource>().Length;
        if (numMusicPlayers != 1)
        {
            Destroy(this.gameObject);
        }
        // if more then one music player is in the scene
        //destroy ourselves
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MuteSound()
    {
        if(isMuted==false)
        {
            isMuted = true;
            mutedOn.SetActive(true);
            muteOff.SetActive(false);
            audio.mute = true;
            PlayerPrefs.SetInt("audio", 0);
        }
        else
        {
            isMuted = false;
            mutedOn.SetActive(false);
            muteOff.SetActive(true);
            audio.mute = false;
            PlayerPrefs.SetInt("audio", 1);
        }
    }
}
