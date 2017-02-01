using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

	public int score;
	public Text ScoreValueObject;
	public Text WinnerLabel;

	// Use this for initialization
	void Start () {
		score = GameManager.score;
		ScoreValueObject.text = score.ToString ();
		if (GameManager.winner == true) {
			WinnerLabel.text = "YOU'RE WINNER!";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
