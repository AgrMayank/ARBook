using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour {

	Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter (Collider other)
	{
		if (transform.CompareTag ("ShipWall"))
		{
			transform.localPosition = pos;
		}
	}
}
