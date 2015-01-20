using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

    private Rect _buttonRect = new Rect(550, 200, 100, 50);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        var e = Event.current;
        if (e.isMouse && e.type == EventType.MouseDown)
        {
            if (_buttonRect.Contains(e.mousePosition))
                Application.LoadLevel("Main");
        }

        GUI.Button(_buttonRect, "Restart");
    }
}
