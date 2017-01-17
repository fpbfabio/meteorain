using UnityEngine;
using System.Collections;

public class GoSceneTimeScript : MonoBehaviour {

	public string scene;
	public float time;

	void Start () {
		Invoke ("GoScene", time);
	}
	
	void GoScene () {
		Application.LoadLevel (scene);
	}
}
