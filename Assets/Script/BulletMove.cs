using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	public float moveSpeed = 3;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up * moveSpeed;
	}

}
