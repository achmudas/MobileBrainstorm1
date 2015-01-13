using UnityEngine;
using System.Collections;


public class CubeGenerator : MonoBehaviour {

	public Transform cube;
	

	void Start() {
	    InvokeRepeating("CreateRandomCube", .15f, 1.0F);  
	}
	
	// Update is called once per frame
	void Update () {
  
	}

	void CreateRandomCube() {
		Instantiate(cube, new Vector3(10.9f, 0.98f, -1), Quaternion.identity);
	}

	
}
