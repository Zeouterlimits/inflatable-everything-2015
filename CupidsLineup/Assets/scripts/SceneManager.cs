using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		WaitForSeconds(5);
		Application.LoadLevel("02_lineup");
	}
}
