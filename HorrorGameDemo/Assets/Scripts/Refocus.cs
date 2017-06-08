using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Refocus : MonoBehaviour {
    public DepthOfField dof;
    public Collider ghostCollider;
    public float maxDistanceToCollider = 5f;
    private int onOff = 1;
	
	void Start () {
        InvokeRepeating("RefocusUpdate", 0, 0.1f);
        try
        {
            ghostCollider = GameObject.Find("default").GetComponent<Collider>();
        }
        catch
        {
            onOff = 0;
            Debug.Log("no ghost this level");
        }


    }
		
	void RefocusUpdate () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //if ((Physics.Raycast(transform.position, transform.forward, out hit))
        if (Physics.Raycast(ray, out hit))
        {
            dof.focalLength = hit.distance;
        }
		
        if (onOff == 1)
        {
            if (ghostCollider.Raycast(ray, out hit, maxDistanceToCollider))
            {
                Debug.Log("Raycast works");
                GameObject.Find("default").GetComponent<TriggerLightON>().trig = 1;
            }
        }
        
	}
}
