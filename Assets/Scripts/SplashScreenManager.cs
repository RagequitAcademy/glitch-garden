using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	// Use this for initialization
	void Start () {
		Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
	}

	void LoadNextLevel() {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
