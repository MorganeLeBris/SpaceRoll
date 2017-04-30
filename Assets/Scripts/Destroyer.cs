﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Player"){
			Debug.Break ();
			return;
		}
		if(other.gameObject.transform.parent){
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else{
			Destroy (other.gameObject);
		}
	}

}
