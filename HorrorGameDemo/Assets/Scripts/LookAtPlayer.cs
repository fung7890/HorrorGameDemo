using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    Transform player;
    public float speed = 0.5f;
    Quaternion neededRotation;
    Quaternion interpolatedRotation;
    GameObject[] heads;
    public int waitTime;
    AudioSource audio1;
    AudioSource audio2;



    // Use this for initialization
    void Start()
    {
        heads = GameObject.FindGameObjectsWithTag("head");


        

    }
    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("FirstPersonCharacter").transform;

        //neededRotation = (Quaternion.LookRotation(transform.position + player.position));

        //transform.rotation = Quaternion.Lerp(transform.rotation, neededRotation, Time.deltaTime*speed);
    }

    IEnumerator waitAndScare()
    {
        audio1.enabled = true;

        yield return new WaitForSeconds(audio1.clip.length);

        audio2.enabled = true;

        foreach (GameObject head in heads)
        {
            head.transform.LookAt(player);

        }
        gameObject.SetActive(false);
    }
    public void OnTriggerEnter(Collider LookTrigger)
    {
        
        heads = GameObject.FindGameObjectsWithTag("head");
        audio1 = GameObject.Find("CreepySound").GetComponent<AudioSource>();
        audio2 = GameObject.Find("CreepySound2").GetComponent<AudioSource>();

        player = GameObject.Find("FirstPersonCharacter").transform;
            
        StartCoroutine(waitAndScare());

    }
}
