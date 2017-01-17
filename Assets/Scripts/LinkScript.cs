using UnityEngine;
using System.Collections;

public class LinkScript : MonoBehaviour {

	public string url;
	private void OnButtonDown(){
		Application.OpenURL (url);
	}
}
