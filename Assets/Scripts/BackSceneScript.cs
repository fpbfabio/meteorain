using UnityEngine;
using System.Collections;

public class BackSceneScript : MonoBehaviour {

	public string scene;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel (scene);
		}
	}
}
