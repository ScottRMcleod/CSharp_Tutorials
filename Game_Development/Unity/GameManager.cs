using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static int currentScore;
	public static int highScore;

	public static int currentLevel;
	public static int unlockLevel;

	public Rect timerRect;

	public GUISkin skin;
	public Color warningColour;

	public float startTime;
	private string currentTime;

	void Update()
	{
		startTime -= Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime); 
		print (currentTime);
		if (startTime <= 0) 
		{
			startTime = 0;
			Application.LoadLevel(2);
		}

	}
	void Start()
	{
		DontDestroyOnLoad (gameObject);
	}
	public static void CompleteLevel()
	{
		if (currentLevel < 2) {
			currentLevel += 1;
			Application.LoadLevel (currentLevel);
		} 
		else 
		{
			print ("You Win");
		}
	}
	void OnGUI()
	{
		GUI.Label (timerRect,currentTime, skin.GetStyle("Timer"));
	}
}
