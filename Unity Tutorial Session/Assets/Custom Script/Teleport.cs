using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject exitPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Vector3 pAdd;
        pAdd.x = 0;
        pAdd.y = 2;
        pAdd.z = 0;

        other.transform.position = exitPoint.transform.position + pAdd;
    }
}
