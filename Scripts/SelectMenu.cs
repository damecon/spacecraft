using UnityEngine;
using System.Collections;

public class SelectMenu : MonoBehaviour {

	void OnGUI(){
		const int buttonWidth = 80;
		const int buttonHeight = 60;

		Rect buttonRectS1 = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
		);

		Rect buttonRectS2 = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2) - 80,
			buttonWidth,
			buttonHeight
		);

		Rect buttonRectS3 = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2) - 160,
			buttonWidth,
			buttonHeight
		);

		if(GUI.Button (buttonRectS1, "Stage 3")) {
			Application.LoadLevel ("Stage3");
		} else if(GUI.Button (buttonRectS2, "Stage 2")) {
			Application.LoadLevel ("Stage2");
		} else if(GUI.Button (buttonRectS3, "Stage 1")) {
			Application.LoadLevel ("Stage1");
		}

	}
}