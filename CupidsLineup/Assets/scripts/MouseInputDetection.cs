using UnityEngine;
using System.Collections;

public class MouseInputDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X") < 0) {
			//print("Mouse moved left");
		}
	
	}
}
