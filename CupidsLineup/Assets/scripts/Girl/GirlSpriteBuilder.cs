using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GirlSpriteBuilder : MonoBehaviour {

	public int chosenHead;
	public int chosenBody;
	public int chosenLegs;
	public int chosenOther;
	public string chosenInput;
	
	Transform childBody;
	Transform childLegs;
	Transform childHead;
	Transform childOther;


	// Use this for initialization
	void Start () {
		childHead = transform.Find("Head");
		childBody = transform.Find("Body");
		childLegs = transform.Find("Legs");
		childOther = transform.Find("Other");

		setCorrectSprites ();
	}

	void setCorrectSprites ()
	{
			Sprite headSprite = Resources.Load ("head_" + chosenHead, typeof(Sprite)) as Sprite;	
			childHead.GetComponent<SpriteRenderer> ().sprite = headSprite;

			Sprite bodySprite = Resources.Load ("body_" + chosenBody, typeof(Sprite)) as Sprite;
			childBody.GetComponent<SpriteRenderer> ().sprite = bodySprite;

			Sprite accessorySprite = Resources.Load ("other_" + chosenOther, typeof(Sprite)) as Sprite;
			childOther.GetComponent<SpriteRenderer> ().sprite = accessorySprite;

			Sprite legSprite = Resources.Load ("legs_" + chosenLegs, typeof(Sprite)) as Sprite;
			childLegs.GetComponent<SpriteRenderer> ().sprite = legSprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
