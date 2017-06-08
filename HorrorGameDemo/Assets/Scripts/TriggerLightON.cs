using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightON : MonoBehaviour {

    public float trig = 0;
    public GameObject destroy;
    public float disappearTime = 1;
    ScareSound r;

	// Use this for initialization
	void Start () {
        r = GameObject.Find("FirstPersonCharacter").GetComponent<ScareSound>();
    }
	
	// Update is called once per frame
	void Update () {

        if (trig == 1)
        {
            GameObject.Find("GhostLight").GetComponent<Light>().enabled = true;
            r.Scare();
            GameObject.Destroy(destroy, disappearTime);
            GameObject.Find("FlickLight").GetComponent<Light>().enabled = true;
            GameObject.Find("FlickLight").GetComponent<Flicker>().onOff = 1;

        }




    }

    
}
