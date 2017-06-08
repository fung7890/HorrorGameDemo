using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScareSound : MonoBehaviour {

    public float soundVolume = 0.8f;
    public AudioClip scareSound;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();

    }


    public void Scare()
    {
        audio.PlayOneShot(scareSound, soundVolume);
    }
}
