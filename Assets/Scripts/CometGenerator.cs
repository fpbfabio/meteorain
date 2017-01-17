using UnityEngine;
using System.Collections;

public class CometGenerator : MonoBehaviour {

	public GameObject prefab;
	public float velocity;
	public int time;
	public float delay;

	void Start () {
		Invoke ("GenComet", delay);
		Invoke ("RaiseLevel", 10.5f * time);
	}

	private void GenComet () {
		GameObject comet = Instantiate (prefab) as GameObject;
		comet.transform.position = new Vector3 (Random.value * 8 - 4, transform.position.y, transform.position.z);
		comet.GetComponent<Rigidbody2D>().velocity = -Vector2.up * velocity;
		Invoke ("GenComet", time);
	}

	private void RaiseLevel () {
		GenComet ();
		Invoke ("RaiseLevel", 10.7f * time);
	}
}
