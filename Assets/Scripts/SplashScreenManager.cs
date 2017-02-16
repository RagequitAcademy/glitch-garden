using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("ChangeLevel", 3.0f);
		Debug.Log ("New Level load: Start");
	}

	void ChangeLevel() {
		Application.LoadLevel ("Start Menu");
	}
}
