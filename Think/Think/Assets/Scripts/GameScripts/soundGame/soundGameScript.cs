using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundGameScript : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;

    public void WlaczDzwiek1()
    {
        audioSource1.mute = false;
        audioSource2.mute = true;
        audioSource3.mute = true;
        audioSource4.mute = true;
        audioSource1.Play();
    }

    public void WlaczDzwiek2()
    {
        audioSource2.mute = false;
        audioSource1.mute = true;
        audioSource3.mute = true;
        audioSource4.mute = true;
        audioSource2.Play();
    }

    public void WlaczDzwiek3()
    {
        audioSource3.mute = false;
        audioSource1.mute = true;
        audioSource2.mute = true;
        audioSource4.mute = true;
        audioSource3.Play();
    }

    public void WlaczDzwiek4()
    {
        audioSource4.mute = false;
        audioSource1.mute = true;
        audioSource2.mute = true;
        audioSource3.mute = true;
        audioSource4.Play();
    }
}
