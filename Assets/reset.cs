﻿using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void push(){
		Application.LoadLevel (Application.loadedLevelName);
	}
}
