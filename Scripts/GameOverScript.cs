using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI(){
		const int buttonWidth = 120;
		const int buttonHeight = 60;

		Rect buttonRectRY = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2) - 80,
			buttonWidth,
			buttonHeight
		);

		Rect buttonRectBM = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2) - 160,
			buttonWidth,
			buttonHeight
		);
			
		if(GUI.Button (buttonRectRY, "Retry")) {
			Application.LoadLevel ("Stage1");
		} else if(GUI.Button (buttonRectBM, "Back to Menu")) {
			Application.LoadLevel ("Menu");
		}
	}
}
