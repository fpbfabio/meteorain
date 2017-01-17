using UnityEngine;
using System.Collections;

public class AccelerometerScript : MonoBehaviour {

	public int scale;
	public int angleScale;

	void Update () {
/*		if (Input.acceleration.x < 0.1f && Input.acceleration.x > -0.1f) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
			rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y); 
			return;
		}
*/
		GetComponent<Rigidbody2D>().velocity = new Vector2(Input.acceleration.x * scale, GetComponent<Rigidbody2D>().velocity.y);
		transform.rotation = Quaternion.Euler (new Vector3(0, 0, -Input.acceleration.x) * angleScale);
		//rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * scale, rigidbody2D.velocity.y);transform.rotation = Quaternion.Euler (new Vector3(0, 0, -Input.GetAxis("Horizontal") * 100));
	}
}
