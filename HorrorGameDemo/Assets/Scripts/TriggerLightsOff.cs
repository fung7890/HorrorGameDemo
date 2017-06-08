using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightsOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("works");
        
        GameObject.Find("FlickLight").GetComponent<Flicker>().onOff = 0;

       


    }
}
