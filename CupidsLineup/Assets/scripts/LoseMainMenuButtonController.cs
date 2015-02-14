using UnityEngine;

public class LoseMainMenuButtonController : MonoBehaviour 
{
	public void returnToMainMenu() {
		Application.LoadLevel("00_top_menu");
	}
	
	public void playAgain() {
		Application.LoadLevel("01_girl_description");
	}
}


