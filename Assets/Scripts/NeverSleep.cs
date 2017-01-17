using UnityEngine;
using System.Collections;

public class NeverSleep : MonoBehaviour {

	void Awake () {
		Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
	}
}
