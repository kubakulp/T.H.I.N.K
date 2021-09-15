using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudioInMenu : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        PlayerPrefs.SetInt("audio", 1);
    }
}
