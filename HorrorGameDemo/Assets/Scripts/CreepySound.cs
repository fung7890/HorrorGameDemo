﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepySound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("creepy works");

        GameObject.Find("CreepySound").GetComponent<AudioSource>().enabled = true;




    }
}
