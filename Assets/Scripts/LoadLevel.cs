using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string scene;

	void OnButtonDown () {
		Time.timeScale = 1;
		Invoke ("Load", 0.4f);
	}

	private void Load () {
		if (scene == "Game" && PlayerPrefs.GetInt("FirstTime",0) == 0) {
			scene = "HowToPlay";
		}
		Application.LoadLevel (scene);
	}

}
