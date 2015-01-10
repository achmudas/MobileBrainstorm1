using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Button : MonoBehaviour {

	public string colorName;
	public Color color = Color.red;
	private bool collided = false;
	private GameObject collidedGameObject;
	private Cube cubeToBeInstantianed;

	private Dictionary<string, Color> colors;

	// Use this for initialization
	void Start () {
		colors = new Dictionary<string, Color>();
		colors.Add("red", Color.red);
		colors.Add("yellow", Color.yellow);
		colors.Add("blue", Color.blue);
		colors.Add("green", Color.green);
		if (colors.ContainsKey(colorName)) {
			color = colors[colorName];
     		renderer.material.color = color;
     	} 
		//gameObject.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		if (collided) {
			Debug.Log("Update collided");
		}
	}

	void OnCollisionEnter(Collision collision) {
		Cube cubeScript = collision.gameObject.GetComponent <Cube>();
		if (cubeScript.color == color) {
			
			collidedGameObject = collision.gameObject;
			collided = true;
			Debug.Log("Collided " + collided);
		}
		
	}

	void OnCollisionExit(Collision collision){
		Debug.Log("Collided exit " + collided);
		collided = false;
	}

	void OnMouseDown() {
		Debug.Log("Bool " + collided);
		if (collided) {
			Debug.Log("Destroyed");
			Object.Destroy(collidedGameObject);
			collided = false;
		}	else {
			
		}
	}

}
