using UnityEngine;
using System.Collections;

public class GirlEvents : MonoBehaviour {

	string var;

	// Use this for initialization
	void Start () {
		print ("start");
		var = GetComponent<GirlSpriteBuilder>().chosenInput;
		Debug.Log("var value: " + var);
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown(var)) {
			Debug.Log("girl clicked");
			print ();
		}

		if (Input.GetMouseButtonDown(0)) {
			Debug.Log("Pressed left click.");
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				Debug.Log ("Name = " + hit.collider.name);
				Debug.Log ("Tag = " + hit.collider.tag);
				Debug.Log ("Hit Point = " + hit.point);
				Debug.Log ("Object position = " + hit.collider.gameObject.transform.position);
				Debug.Log ("--------------");
			}
		}



	}

	void FixedUpdate () 
	{
		//
	}

	void OnMouseDown() {
		Debug.Log ("clicked");
		print ("girl clicked");
	}

	void OnMouseEnter () {
		Debug.Log ("mouse enter");
	}
	void OnMouseExit () {
		Debug.Log ("mouse exit");
	}

	public void print() {
		Debug.Log(this.name);
	}
}
