using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	void OnButtonDown () {
		Time.timeScale = 1;
		Invoke ("Exit", 0.1f);
	}

	private void Exit () {
		Application.Quit ();
	}
}
