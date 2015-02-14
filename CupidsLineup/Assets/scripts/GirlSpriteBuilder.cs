using UnityEngine;
using System.Collections;

public class GirlSpriteBuilder : MonoBehaviour {

	public int chosenHead;
	public int chosenBody;
	public int chosenLegs;
	public int chosenOther;
	
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
		if (chosenHead == 1) {
			Sprite headSprite = Resources.Load ("head_normal_eyes", typeof(Sprite)) as Sprite;	
			childHead.GetComponent<SpriteRenderer> ().sprite = headSprite;
			//childHead.localScale = new Vector3( 5f, 5f, 5f);
		}
		if (chosenBody == 1) {
			//childBody.position += Vector3.down * 15f;
			Sprite bodySprite = Resources.Load ("basic_tshirt_with_arms", typeof(Sprite)) as Sprite;
			childBody.GetComponent<SpriteRenderer> ().sprite = bodySprite;
			//childBody.localScale = new Vector3( 5f, 5f, 5f);
		}

		if (chosenOther == 1) {
			//childLegs.position += Vector3.down * 40f;
			Sprite accessorySprite = Resources.Load ("basic_accesorises_balloons", typeof(Sprite)) as Sprite;
			childOther.GetComponent<SpriteRenderer> ().sprite = accessorySprite;
			//childLegs.localScale = new Vector3( 5f, 5f, 5f);
		}
		if (chosenLegs == 1) {
			//childLegs.position += Vector3.down * 40f;
			Sprite legSprite = Resources.Load ("basic_pants", typeof(Sprite)) as Sprite;
			childLegs.GetComponent<SpriteRenderer> ().sprite = legSprite;
			//childLegs.localScale = new Vector3( 5f, 5f, 5f);
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
