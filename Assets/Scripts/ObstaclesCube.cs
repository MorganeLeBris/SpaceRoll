﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		Debug.Log("Game Over");
		FindObjectOfType<HUD> ().GameOver ();
	}


}
