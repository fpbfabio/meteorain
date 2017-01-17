using UnityEngine;
using System.Collections;

public class PlayerPrefToText : MonoBehaviour {

	public string playerPref;
	private TextMesh mesh;

	// Use this for initialization
	void Start () {
		mesh = GetComponent<TextMesh> ();
		mesh.text = PlayerPrefs.GetInt (playerPref, 0).ToString();
	}

}
