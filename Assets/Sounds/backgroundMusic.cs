﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour {

	public AudioClip chatter;

	// Use this for initialization
	void Start () {
		AudioSource.PlayClipAtPoint (chatter, transform.position);
	}
}