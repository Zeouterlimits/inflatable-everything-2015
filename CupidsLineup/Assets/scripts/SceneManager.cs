using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		wait ();
		Application.LoadLevel("02_lineup");
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(3);
	}
}
