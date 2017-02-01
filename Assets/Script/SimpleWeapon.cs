using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWeapon : IWeapon {

	private GameObject projectilePrefab;

	public SimpleWeapon(GameObject projectile)
	{
		projectilePrefab = projectile;
	}

	public void Fire(Vector2 position)
	{
		GameObject.Instantiate (projectilePrefab, position, Quaternion.identity);
	}
}
