using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    private GUIStyle gameOverStyle = new GUIStyle();
    private GUIStyle scoreStyle = new GUIStyle();
    private Rect restartReact = new Rect(450, 340, 100, 50);
    private Rect quitReact = new Rect(450, 350, 100, 50);

   private int totalPoints = 0;


	// Use this for initialization
	void Start () {

       if(PlayerPrefs.HasKey("totalPoints")) { totalPoints =  PlayerPrefs.GetInt("totalPoints");}

	    gameOverStyle.fontSize = 50;
        gameOverStyle.normal.textColor = Color.red;

        scoreStyle.fontSize = 40;
        scoreStyle.normal.textColor = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {

        GUI.Label(new Rect(350, 100, 300, 50), "GAME OVER", gameOverStyle);

        GUI.Label(new Rect(450, 200, 300, 50), "Score", scoreStyle);
        GUI.Label(new Rect(485, 250, 300, 50), totalPoints.ToString(), scoreStyle);
       

        var e = Event.current;
        if (e.isMouse && e.type == EventType.MouseDown)
        {
            if (restartReact.Contains(e.mousePosition))
                Application.LoadLevel("Main");

            if (quitReact.Contains(e.mousePosition))
                Application.Quit();
        }

        GUI.Button(restartReact, "Restart");
      //  GUI.Button(quitReact, "Quit");
    }
}
