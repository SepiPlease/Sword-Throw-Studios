﻿using UnityEngine;
using System.Collections;

public class Interactions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Inv")){
			transform.GetComponent<Inventory>().toggle();
		}
	}
}
