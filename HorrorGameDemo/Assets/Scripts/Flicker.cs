using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour {

    public float minFlickerTime = 0.5f;
    public float onOff = 1;
    public float maxFlickerTime = 1f;
    public float soundVolume = 0.8f;
    public AudioClip flickerSound;
    AudioSource audio;

    Light flickerLight;

	// Use this for initialization
	void Start () {

        flickerLight = GetComponent<Light>();
        audio = GetComponent<AudioSource>();

        StartCoroutine(Flashing());
		
	}

    IEnumerator Flashing()
    {
        while (onOff == 1)
        {
            yield return new WaitForSeconds(Random.Range(minFlickerTime, maxFlickerTime));
            flickerLight.enabled = !flickerLight.enabled;
            audio.PlayOneShot(flickerSound, soundVolume);
        }
       
       flickerLight.enabled = false;
        
    }

}
