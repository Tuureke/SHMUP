using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDamage : MonoBehaviour, IDamageable, IKill {

	public int hitPoints = 1;
	public GameObject explosionPrefab;
	public int scoreValue = 100;
	public float DestroyDelayTime = 0.5f;
	public AudioSource destroyAudio;

	public void Damage(int value)
	{
		hitPoints -= value;
		if(hitPoints <= 0)
		{
			Kill ();
		}
	}

	public void Kill()
	{
		GameObject.Instantiate (explosionPrefab, transform.position, Quaternion.identity);
		Destroy(gameObject, DestroyDelayTime);
		destroyAudio.Play ();
		GameObject.Find ("GameManager").GetComponent<GameManager> ().AddScore (scoreValue);
	}
		
}
