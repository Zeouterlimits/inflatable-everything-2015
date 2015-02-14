using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void onClick() {
		Application.LoadLevel("01_girl_description");
	}
}
