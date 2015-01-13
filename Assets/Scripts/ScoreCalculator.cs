using UnityEngine;
using System.Collections;

public class ScoreCalculator : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle();
    public int numberOfDestroyedCubes = 0;

    void Start()
    {
        guiStyle.fontSize = 50;
        guiStyle.normal.textColor = Color.white;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(650, 100, 300, 50), numberOfDestroyedCubes.ToString(), guiStyle);
    }
}
