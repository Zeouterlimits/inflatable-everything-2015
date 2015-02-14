using UnityEngine;
using System.Collections;

public class GirlSpriteBuilder : MonoBehaviour {

	public int chosenHead;
	public int chosenBody;
	public int chosenLegs;

	GameObject head;
	GameObject body;
	GameObject legs;

	Transform childHead;

	// Use this for initialization
	void Start () {
		head = GameObject.Find("Head");
		body = GameObject.Find("Body");
		legs = GameObject.Find("Legs");

		//childHead = Transform.Find("Head");

		if(chosenHead == 1) {
			Sprite myFruit = Resources.Load("head_normal_eyes", typeof(Sprite)) as Sprite;

			//Texture2D headTexture = (Texture2D) Resources.Load("head_normal_eyes");
			head.GetComponent<SpriteRenderer>().sprite = myFruit;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
