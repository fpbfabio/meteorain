using UnityEngine;
using System.Collections;

public class DieScript : MonoBehaviour {

	public float gravityScale;
	private Animator animator;
	private AccelerometerScript aScript;
	private GameObject cometGen;
	private ParallaxScript pScript;
	private AudioSource explosion;
    private bool fall = false;

	void Start() {
		explosion = GameObject.FindGameObjectWithTag ("Explosion").GetComponent<AudioSource>();
		pScript = GameObject.FindGameObjectWithTag ("Star").GetComponent<ParallaxScript>();
		animator = GetComponent<Animator> ();
		aScript = GetComponent<AccelerometerScript> ();
	}

	public void Die () {
		GameObject.FindGameObjectWithTag ("Scorer").SendMessage("Stop");
		Destroy(GameObject.FindGameObjectWithTag ("Fire"));
		Destroy(GameObject.FindGameObjectWithTag ("CometGen"));
		pScript.enabled = false;
		explosion.GetComponent<AudioSource>().Play ();
		aScript.enabled = false;
		Invoke ("Fall", 0.4f);
	}

    void FixedUpdate()
    {
        if (fall)
        {
            GetComponent<Rigidbody2D>().gravityScale = gravityScale;
            Camera.main.GetComponent<Rigidbody2D>().gravityScale = gravityScale;
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
    }

    private void Fall () {
        fall = true;
	}

	private void LoadLevel () {
		Application.LoadLevel ("GameOver");
	}

	private void BeInvisible () {
		transform.position += 50 * Vector3.forward;
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Floor") {
			animator.SetTrigger ("Die");
			explosion.GetComponent<AudioSource>().Play ();
			Invoke("BeInvisible", 0.4f);
			Invoke("LoadLevel", 2f);
		}
	}
}
