using UnityEngine;
using System.Collections;

public class DestroySchedule : MonoBehaviour {

	public float time;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, time);
	}
	
}
