using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (new Rect (100, 10, 200, 45), "Main Menu");
		if (GUI.Button (new Rect (100, 150, 200, 45), "Play")) 
		{
			Application.LoadLevel(0);
		}
		if (GUI.Button (new Rect (100,205, 200, 45), "Options")) 
		{
			Application.Quit();
		}
		if (GUI.Button (new Rect (100,255, 200, 45), "Quit")) 
		{
			Application.Quit();
		}
	}
}
