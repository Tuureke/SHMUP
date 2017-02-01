using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class HiScore
{
	public string name;
	public int score;
}

[System.Serializable]
public class HiScores
{
	public HiScore[] scores;
}

public class HTTPReadWrite : MonoBehaviour {

	void Start() {
		StartCoroutine(GetText());
	}

	IEnumerator GetText() {
		UnityWebRequest www = UnityWebRequest.Get("localhost:5000/scores"); //"https://highscore-server-tuure.herokuapp.com/"
		yield return www.Send();

		if(www.isError) {
			Debug.Log(www.error);
		}
		else {
			// Show results as text
			Debug.Log(www.downloadHandler.text);
			HiScores hs = JsonUtility.FromJson<HiScores> (www.downloadHandler.text);

			Debug.Log (hs.scores.Length);
			foreach (HiScore h in hs.scores) {
				Debug.Log ("name is " + h.name);
				Debug.Log ("score is " + h.score);
			}

			// Or retrieve results as binary data
			byte[] results = www.downloadHandler.data;
		}
	}

	public void PostHighScore()
	{
		Debug.Log ("Tuut");

		HiScore hs = new HiScore ();
		hs.name = "Esimerkki";
		hs.score = 20;

		StartCoroutine(POST(hs));
	}

	IEnumerator POST(HiScore hs)
	{
		Dictionary<string, string> headers = new Dictionary<string, string> ();
		headers.Add ("Content-Type", "application/json");

		string jsonData = JsonUtility.ToJson (hs);
		byte[] postData = System.Text.Encoding.UTF8.GetBytes (jsonData);

		WWW www = new WWW ("localhost:5000/scores",
							postData,
							headers);

		yield return www;

		Debug.Log (www);
	}

}
