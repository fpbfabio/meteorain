using UnityEngine;
using System.Collections;

public class ParallaxScript : MonoBehaviour {
	
	public GameObject[] objects;
	public Vector2[] velocities;
	
	void FixedUpdate () {
		for (int i = 0; i < objects.Length; i++) {
			objects[i].GetComponent<Renderer>().materials[0].mainTextureOffset = objects[i].GetComponent<Renderer>().materials[0].mainTextureOffset.y <= 0.5 ? objects[i].GetComponent<Renderer>().materials[0].mainTextureOffset + velocities[i] : objects[i].GetComponent<Renderer>().materials[0].mainTextureOffset - 0.5f * Vector2.up ;
		}
	}
}
