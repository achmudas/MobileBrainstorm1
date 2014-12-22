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
	
	}

	void OnCollisionEnter(Collision collision) {
		collidedGameObject = collision.gameObject;
		Cube cubeScript = collidedGameObject.GetComponent <Cube>();
		if (cubeScript.color == color) {
			collided = true;
		}
		
	}

	void OnCollisionExit(Collision collision){
		collided = false;
	}

	void OnMouseDown() {
		if (collided) {
			Object.Destroy(collidedGameObject);
			collided = false;
		}	else {
			
		}
	}

}
