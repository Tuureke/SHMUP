using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour {

	private List<IWeapon> activeWeapons = new List<IWeapon>();
	//private List<IWeapon> activeWeapons2 = new List<IWeapon>();



	public GameObject simpleWeaponProjectile;
	public GameObject powerfulWeaponProjectile;

	// Use this for initialization
	void Start () {
		activeWeapons.Add (new SimpleWeapon (simpleWeaponProjectile));
		//activeWeapons2.Add (new PowerfulWeapon (powerfulWeaponProjectile));
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")){
			foreach(IWeapon w in activeWeapons){
				w.Fire(transform.position);
			}
		}
		/*if (Input.GetButtonDown ("Jump")){
			foreach(IWeapon w in activeWeapons2){
				w.Fire(transform.position);
			}
		}*/

	}

	public void AddWeapon(PlayerWeaponEnums weaponType)
	{
		Debug.Log ("Add new weapon");
		switch (weaponType) {
			case PlayerWeaponEnums.BasicBlaster:
				activeWeapons.Clear();
				activeWeapons.Add(new SimpleWeapon(powerfulWeaponProjectile));	
				break;
			case PlayerWeaponEnums.TwinBlaster:
				break;
			case PlayerWeaponEnums.VWeapon:
				break;
			default:
				Debug.Log ("WeaponType " + weaponType + " not implemented");
				return;
		}
	}
}
