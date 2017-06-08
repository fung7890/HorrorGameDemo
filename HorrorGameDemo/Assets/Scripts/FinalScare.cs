using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScare : MonoBehaviour {

    Camera cam1;
    Camera cam2;
    MeshRenderer finalWall; 
	// Use this for initialization
	void Start () {
        cam1 = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
        cam2 = GameObject.Find("FinalCamera").GetComponent<Camera>();
        finalWall = GameObject.Find("FinalWall").GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        cam1.enabled = false;
        cam2.enabled = true;
        Debug.Log("final works");
        GameObject.Find("FirstPersonCharacter").GetComponent<AudioListener>().enabled = false;

        GameObject.Find("FinalSound").GetComponent<AudioListener>().enabled = true;

        GameObject.Find("FinalSound").GetComponent<AudioSource>().enabled = true;


        StartCoroutine(Final());


    }

    IEnumerator Final()
    {
        yield return new WaitForSeconds(1);
        finalWall.enabled = true;

    }
}
