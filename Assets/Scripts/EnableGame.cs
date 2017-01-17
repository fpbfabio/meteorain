using UnityEngine;
using System.Collections;

public class EnableGame : MonoBehaviour {

	void Start () {
		PlayerPrefs.SetInt ("FirstTime", 1);
	}
	
}
