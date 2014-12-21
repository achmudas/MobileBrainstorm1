using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	public Color color = Color.red;

	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
