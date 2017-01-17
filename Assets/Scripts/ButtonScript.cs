using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public bool playSound;
	private AudioSource audioSource;
	private Vector3 normalScale;

	void Start () {
		normalScale = transform.localScale;
		if (playSound)
			audioSource = GetComponent<AudioSource>();
	}

	void OnMouseDown () {
		transform.localScale = new Vector3 (normalScale.x - 0.2f, normalScale.y - 0.2f, 0);
		if (playSound)
			audioSource.GetComponent<AudioSource>().Play();
		Invoke ("ResetSprite", 0.5f);
		gameObject.SendMessage ("OnButtonDown");
	}

	void OnMouseUp () {
		transform.localScale = normalScale;
	}

	private void ResetSprite () {
		OnMouseUp ();
	}
}
