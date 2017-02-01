using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithEnemy : MonoBehaviour {


	void Start()
	{
		
	}

	void OnTriggerEnter2D(Collider2D c){
		if (((c.gameObject.tag == "Enemy") || (c.gameObject.tag == "Boss")) && (GameManager.immunity == false)) {
			Debug.Log ("DEADED");
			Debug.Log (GameManager.immunity);
			Destroy (gameObject);
			GameObject.Find ("GameManager").GetComponent<GameManager> ().PlayerKilled ();
		}	
	}
}
