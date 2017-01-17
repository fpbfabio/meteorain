using UnityEngine;
using System.Collections;

public class OnCometTrigger : MonoBehaviour {

	public string colliderObjTag;
	public string colliderObjMessage;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();	
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == colliderObjTag) {
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().gravityScale = 0;
			col.gameObject.SendMessage(colliderObjMessage);
			animator.SetTrigger("Explode");
			Destroy(gameObject, 1f);
		}
	}
}
