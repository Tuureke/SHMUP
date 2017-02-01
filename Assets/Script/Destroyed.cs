using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour {

	public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
		GameObject.Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
	

}
