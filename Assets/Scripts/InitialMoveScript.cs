using UnityEngine;
using System.Collections;

public class InitialMoveScript : MonoBehaviour {

	private ParallaxScript pScript;
	private AudioSource audioSource;
    private Rigidbody2D body;
	public float heightToStop;
	public bool playSound;

	void Start() {
		pScript = GameObject.FindGameObjectWithTag ("Star").GetComponent<ParallaxScript>();
		pScript.enabled = false;
		if (playSound) {
			audioSource = GetComponent<AudioSource> ();
			audioSource.Play ();
		}
        body = GetComponent<Rigidbody2D>();
        body.velocity = Vector2.up;
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (transform.position.y < heightToStop)
        {
            return;
        }
        Debug.Log("stop " + transform.position.y);
        pScript.enabled = true;
        body.velocity = Vector2.zero;
		enabled = false;
	}
}
