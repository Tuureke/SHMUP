using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerfulWeapon : IWeapon {

	private GameObject projectilePrefab;

	public PowerfulWeapon(GameObject projectile)
	{
		projectilePrefab = projectile;
	}

	public void Fire(Vector2 position)
	{
		GameObject.Instantiate (projectilePrefab, position, Quaternion.identity);
	}
}
