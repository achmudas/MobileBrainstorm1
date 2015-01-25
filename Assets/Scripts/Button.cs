using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Button : MonoBehaviour {

	public string colorName;
	public Color color = Color.red;
	private bool collided = false;
	private Cube cubeToBeInstantianed;

	private Dictionary<string, Color> colors;
    private LinkedList<GameObject> collidedGameObjects;

    private ScoreCalculator scoreCalculator;

    private GUIStyle guiStyle = new GUIStyle();
    private bool gameOver = false;



	// Use this for initialization
	void Start () {

        guiStyle.fontSize = 50;
        guiStyle.normal.textColor = Color.black;

        scoreCalculator = GameObject.FindWithTag("scoreCalculator").gameObject.GetComponent<ScoreCalculator>();
        collidedGameObjects = new LinkedList<GameObject>();
		colors = new Dictionary<string, Color>();
		colors.Add("red", Color.red);
		colors.Add("yellow", Color.yellow);
		colors.Add("blue", Color.blue);
		colors.Add("green", Color.green);
		if (colors.ContainsKey(colorName)) {
			color = colors[colorName];
            renderer.material.color = color;
     	} 
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision) {
        GameObject tempCube = collision.gameObject;
		Cube cubeScript = tempCube.GetComponent <Cube>();
		if (cubeScript.color.Equals(color)) {
            collided = true;
            collidedGameObjects.AddLast(tempCube);
		}
		
	}

	void OnCollisionExit(Collision collision){
        gameOver = true;        
	}

    void OnGUI()
    {

        if (gameOver)
        {
            PlayerPrefs.SetInt("totalPoints", scoreCalculator.numberOfDestroyedCubes);
            Application.LoadLevel("GameOver");
            
        }
    }

	void OnMouseDown() {
		if (collided) {
            scoreCalculator.numberOfDestroyedCubes++;
			Object.Destroy(collidedGameObjects.First.Value);
            collidedGameObjects.Remove(collidedGameObjects.First.Value);
            if (collidedGameObjects.Count == 0)
            {
                collided = false;
            }
   		}	else {
			
		}
	}




}
