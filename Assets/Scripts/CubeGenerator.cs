﻿using UnityEngine;
using System.Collections;


public class CubeGenerator : MonoBehaviour {

	public Transform cube;
	

	void Start() {
	    InvokeRepeating("CreateRandomCube", .35f, 1.25F);
	  
	}
	
	// Update is called once per frame
	void Update () {
  
	}

	void CreateRandomCube() {
		Instantiate(cube, new Vector3(16.9f, 0.98f, 0), Quaternion.identity);
	}

	
}
