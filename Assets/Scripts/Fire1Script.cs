using UnityEngine;
using System.Collections;

public class Fire1Script : MonoBehaviour {

	private GameObject smokeGen;
	private GameObject fire;
	private AccelerometerScript aScript;
	private InitialMoveScript iScript;
	private InitialMoveScript iScript2;
	private GameObject cometGenerator;
	private GameObject scorer;

	// Use this for initialization
	void Awake () {
		GameObject.FindGameObjectWithTag ("Star").GetComponent<ParallaxScript>().enabled = false;
		smokeGen = GameObject.FindGameObjectWithTag ("SmokeGen");
		fire = GameObject.FindGameObjectWithTag ("Fire");
		aScript = GameObject.FindGameObjectWithTag ("Rocket").GetComponent<AccelerometerScript>();
		iScript = GameObject.FindGameObjectWithTag ("Rocket").GetComponent<InitialMoveScript>();
		iScript2 = Camera.main.GetComponent<InitialMoveScript>();
		cometGenerator = GameObject.FindGameObjectWithTag ("CometGen");
		scorer = GameObject.FindGameObjectWithTag ("Scorer");
		scorer.SetActive (false);
		cometGenerator.SetActive(false);
		iScript2.enabled = false;
		iScript.enabled = false;
		aScript.enabled = false;
		smokeGen.SetActive (false);
		fire.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
			scorer.SetActive (true);
			cometGenerator.SetActive(true);
			aScript.enabled = true;
			smokeGen.SetActive (true);
			fire.SetActive (true);
			iScript.enabled = true;
			iScript2.enabled = true;
			enabled = false;
		}
	}
}
