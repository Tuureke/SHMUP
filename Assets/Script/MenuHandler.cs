﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour {

	public void StartGame(){
		Debug.Log ("START GAME");
		GameManager.score = 0;
		StartCoroutine (levelChange ());
	}

	IEnumerator levelChange(){
		yield return SceneManager.LoadSceneAsync("Level1");
	}
}
