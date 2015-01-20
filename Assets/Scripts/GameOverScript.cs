using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    private GUIStyle guiStyle = new GUIStyle();
    public int numberOfDestroyedCubes = 0;

    void Start()
    {
        guiStyle.fontSize = 50;
        guiStyle.normal.textColor = Color.red;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(450, 100, 300, 50), "GAME OVER", guiStyle);
    }
}
