using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	private static string previousLevel;

	public static void setPreviousLevel(string level)
	{
		previousLevel = level;
	}

	public static string getPreviousLevel ()
	{
		return previousLevel;
	}

	public static void changeToPreviousLevel()
	{
		Application.LoadLevel (previousLevel);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
