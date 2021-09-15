using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    private SoundScript soundScript;
    void Start()
    {
        button = GetComponent<Button>();
        soundScript = GetComponent<SoundScript>();
        button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        soundScript.MuteSound();
    }
}
