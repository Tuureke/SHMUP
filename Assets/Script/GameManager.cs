using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int score = 0;
	public Text ScoreValueObject;
	int playerLives = 3;
	public GameObject playerPrefab;
	public GameObject lifeIndicatorHolder;
	public GameObject lifeIconPrefab;
	public static bool immunity;
	public static bool winner = false;

	// Use this for initialization
	void Start () {
		immunity = false;
		updatePlayerLifeUI ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1")) &&
			(GameObject.FindGameObjectWithTag ("Boss") == null)) {
			winner = true;
			GameOver ();
		}
	}

	public void AddScore(int scoreIncrease)
	{
		score += scoreIncrease;
		ScoreValueObject.text = score.ToString ();
	}

	void updatePlayerLifeUI (){
	
		foreach (Transform child in lifeIndicatorHolder.transform) {
			Destroy (child.gameObject);
		}

		for (int i = 0; i < playerLives; i++) {
			GameObject icon = GameObject.Instantiate (lifeIconPrefab, lifeIndicatorHolder.transform);
			RectTransform rt = (RectTransform)icon.transform;
			rt.position = new Vector2 (lifeIndicatorHolder.transform.position.x + i *rt.rect.width - 30f,
										lifeIndicatorHolder.transform.position.y);
			
		
		}

	}

	public void PlayerKilled(){
		winner = false;
		playerLives -= 1;
		updatePlayerLifeUI ();

		if (playerLives == 0) {
			Debug.Log ("Game over");
			GameOver ();
		} 
		else {
			Debug.Log ("Respawn player");
			GameObject.Instantiate (playerPrefab, Camera.main.transform);
			StartCoroutine (Immunity (5));

		}
	}

	public void GameOver(){
		SceneManager.LoadSceneAsync("GameOver");
	}

	IEnumerator Immunity(int seconds){
		immunity = true;
		yield return new  WaitForSeconds(seconds);
		immunity = false;
	}

}
