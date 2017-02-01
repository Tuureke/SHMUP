using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour {

	public GameObject explosionPrefab;
	public int damageValue = 1;

	void OnTriggerEnter2D(Collider2D c)
	{
		if((c.tag == "Enemy") || c.tag == "Boss")
		{
			GameObject.Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			Destroy(gameObject);

			c.gameObject.GetComponent<IDamageable> ().Damage (damageValue);
		}

	}
}
