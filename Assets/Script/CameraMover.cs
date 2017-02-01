using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	public float moveSpeed = 1;

	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, moveSpeed * Time.deltaTime, 0);
	}
}
