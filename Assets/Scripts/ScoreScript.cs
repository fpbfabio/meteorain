using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	private TextMesh mesh;
	public int delay;
	private int score;
	private int bestScore;
	private int time;
	private bool stop;

	void Start () {
		score = 0;
		time = 1;
		stop = false;
		mesh = GetComponent<TextMesh> ();
		mesh.text = score.ToString();
		bestScore = PlayerPrefs.GetInt ("bestscore", 0);
		Invoke ("IncScore", delay);
	}

	private void Stop() {
		stop = true;
	}

	private void IncScore () {
		if (stop)
			return;
		score++;
		mesh.text = score.ToString();
		Invoke ("IncScore", time);
	}

	void OnDestroy() {
		PlayerPrefs.SetInt ("score", score);
		if (score > bestScore) {
			PlayerPrefs.SetInt ("bestscore", score);
		}
	}
}
