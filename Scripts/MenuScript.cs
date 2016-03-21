using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	void OnGUI(){
		const int buttonWidth = 100;
		const int buttonHeight = 80;

		Rect buttonRect = new Rect (
			                  Screen.width / 2 - (buttonWidth / 2),
			                  (2 * Screen.height / 3) - (buttonHeight / 2),
			                  buttonWidth,
			                  buttonHeight
		                  );
			
		if(GUI.Button (buttonRect, "Start Game")) {
			Application.LoadLevel ("StageMenu");
		}


	}
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
