using UnityEngine;
using System.Collections;

public class SmokeGen : MonoBehaviour {

	public GameObject prefab;
	public float smokeSpeed;
	public float time;

	// Use this for initialization
	void Start () {
		GenSmoke ();
	}
	
	private void GenSmoke () {
		GameObject smoke = Instantiate (prefab) as GameObject;
		Vector3[] positions = {
						transform.position,
						transform.position + Vector3.right * 0.1f,
						transform.position - Vector3.right * 0.1f
				};
		int randomPosition = Mathf.CeilToInt(Random.value * positions.Length - 1);
		smoke.transform.position = positions[randomPosition];
		smoke.GetComponent<Rigidbody2D>().velocity = -Vector2.up * smokeSpeed;
		Invoke("GenSmoke", time);
	}
}
