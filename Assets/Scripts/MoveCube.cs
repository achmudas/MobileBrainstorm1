using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	public float speed = 0.05f;
	private Vector2 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}

	void FixedUpdate () {
		position = new Vector2 (position.x - speed, position.y);
		transform.position = position;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
