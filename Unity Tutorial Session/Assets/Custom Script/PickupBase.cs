using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //increase speed temporarily
        other.gameObject.GetComponent<Renderer>().material.color = this.GetComponent<Renderer>().material.color;
        Destroy(this.gameObject);
    }

    
}
