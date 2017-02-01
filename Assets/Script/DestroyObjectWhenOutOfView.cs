﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectWhenOutOfView : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Vector3 bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));

		if(transform.position.y > topRight.y)
		{
			Destroy(gameObject);
		}




	}
}
