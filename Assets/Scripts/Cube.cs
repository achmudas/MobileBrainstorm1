using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube : MonoBehaviour {

	private Dictionary<int, Color> colors;
	public Color color;

	// Use this for initialization
	void Start () {

		colors = new Dictionary<int, Color>();
		colors.Add(1, Color.red);
		colors.Add(2, Color.yellow);
		colors.Add(3, Color.blue);
		colors.Add(4, Color.green);
		color = GenerateRandomColor();
		gameObject.renderer.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	Color GenerateRandomColor() {
		int randomNumber = Random.Range(1, 5);
		Color color = Color.red;
		colors.TryGetValue(randomNumber, out color);
		return color;
	}
}
