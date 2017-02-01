using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Animator a = gameObject.GetComponent<Animator> ();
		a.SetBool ("left", false);
		a.SetBool ("right", false);
		a.SetBool ("immunity", false);

		if (GameManager.immunity == true) {
			a.SetBool ("immunity", true);
		}

		Vector3 move = new Vector3 (0, 0, 0);

		if (Input.GetKey ("left"))
		{
			move.x = -1;
			a.SetBool ("left", true);
		}
		if (Input.GetKey ("right"))
		{
			move.x = 1;
			a.SetBool ("right", true);
		}
		if (Input.GetKey ("up"))
		{
			move.y = 1;
		}
		if (Input.GetKey ("down"))
		{
			move.y = -1;
		}
		Vector3 bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));


		Vector3 currentPos = transform.position;
	

		currentPos += move * Time.deltaTime * moveSpeed;
		currentPos.x = Mathf.Clamp (currentPos.x, bottomLeft.x, topRight.x);
		currentPos.y = Mathf.Clamp (currentPos.y, bottomLeft.y, topRight.y);
	
		transform.position = currentPos;

		//transform.Translate (move * Time.deltaTime * moveSpeed);

	

	}
}
