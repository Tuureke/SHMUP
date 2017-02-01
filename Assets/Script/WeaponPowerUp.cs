using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPowerUp : MonoBehaviour {

	public PlayerWeaponEnums weaponType;

	void OnTriggerEnter2D(Collider2D c){
		if (c.gameObject.tag == "Player") {
			Debug.Log ("pick'd");
			c.gameObject.GetComponent<PlayerWeaponManager> ().AddWeapon (weaponType);
			Destroy (gameObject);
		}	
	}
		

}
