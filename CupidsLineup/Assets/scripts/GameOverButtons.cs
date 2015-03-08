using UnityEngine;
using System.Collections;

public class GameOverButtons : MonoBehaviour {
	
	public void onClickPlayAgain() {
		Application.LoadLevel("01_girl_description");
	}

	public void onClickMainMenu() {
		GameManager.Instance.resetCurrentWinStreak();
		GameManager.Instance.stopMusic ();
		Application.LoadLevel("00_top_menu");
	}
}
