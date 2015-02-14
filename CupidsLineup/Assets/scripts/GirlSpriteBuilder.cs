using UnityEngine;
using System.Collections;

public class GirlSpriteBuilder : MonoBehaviour {

	public int chosenHead;
	public int chosenBody;
	public int chosenLegs;
	
	Transform childBody;
	Transform childLegs;
	Transform childHead;

	// Use this for initialization
	void Start () {
		childHead = transform.Find("Head");
		childBody = transform.Find("Body");
		childLegs = transform.Find("Legs");

		if(chosenHead == 1) {
			Sprite headSprite = Resources.Load("head_normal_eyes", typeof(Sprite)) as Sprite;
			childHead.GetComponent<SpriteRenderer>().sprite = headSprite;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
