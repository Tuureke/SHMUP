using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float moveSpeed = 1;
	public float SinAmplitude = 1;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Mathf.Sin(transform.position.y) * SinAmplitude, -moveSpeed * Time.deltaTime, 0);
	}
}
