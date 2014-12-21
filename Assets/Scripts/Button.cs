using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Color color = Color.red;
	private bool collided = false;
	private GameObject collidedGameObject;
	private Cube cubeToBeInstantianed;

	// Use this for initialization
	void Start () {
		gameObject.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		collidedGameObject = collision.gameObject;
		Cube cubeScript = collidedGameObject.GetComponent <Cube>();
		//Debug.Log("On collision enter");
		if (cubeScript.color == color) {
		//	Debug.Log("Collided in collision");
			collided = true;
		}
		
	}

	void OnCollisionExit(Collision collision){
		collided = false;
		//Gameobject Cube = Gameobject.instantiate(cubetobeinstantianed) As Gameobject;
		//debug.log("game Object: " + Cube);
	}

	void OnMouseDown() {
		//Debug.Log("Collided: " + collided);
		if (collided) {
			Object.Destroy(collidedGameObject);
			collided = false;
		}	else {
			
		}
	}

}
