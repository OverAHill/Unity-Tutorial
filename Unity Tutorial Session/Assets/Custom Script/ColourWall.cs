using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.GetComponent<Collider>().enabled = true;
    }
}
