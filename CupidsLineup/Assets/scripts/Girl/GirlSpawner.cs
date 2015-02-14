using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GirlSpawner : MonoBehaviour {

	public GameObject spriteToDuplicate;
	private GirlAttrs mainGirl;

	private List<GameObject> girls = new List<GameObject>();

	// Use this for initialization
	void Start () {
		mainGirl = GetComponent<GameManager>().getMainGirl();

		Vector3 position1 = new Vector3(-1000f, 0f, 0f);
		Vector3 position2 = new Vector3(-500f, 0f, 0f);
		Vector3 position3 = new Vector3(0f, 0f, 0f);
		Vector3 position4 = new Vector3(500f, 0f, 0f);

		GameObject girl1 = GameObject.Instantiate(spriteToDuplicate, position1, Quaternion.identity) as GameObject;
		GameObject girl2 = GameObject.Instantiate(spriteToDuplicate, position2, Quaternion.identity) as GameObject;
		GameObject girl3 = GameObject.Instantiate(spriteToDuplicate, position3, Quaternion.identity) as GameObject;
		GameObject girl4 = GameObject.Instantiate(spriteToDuplicate, position4, Quaternion.identity) as GameObject;

		girl1.GetComponent<GirlSpriteBuilder>().chosenInput = "Fire1";
		girl2.GetComponent<GirlSpriteBuilder>().chosenInput = "Fire2";
		girl3.GetComponent<GirlSpriteBuilder>().chosenInput = "Fire3";
		girl4.GetComponent<GirlSpriteBuilder>().chosenInput = "Jump";

		girl1.name = "girl1";
		girl2.name = "girl2";
		girl3.name = "girl3";
		girl4.name = mainGirl.personName;

		girls.Add(girl1);
		girls.Add(girl2);
		girls.Add(girl3);

		foreach(GameObject girl in girls) {
			girl.GetComponent<GirlSpriteBuilder>().chosenBody = Random.Range(1,3); //int random is exclusive
			girl.GetComponent<GirlSpriteBuilder>().chosenHead = Random.Range(1,7);
			girl.GetComponent<GirlSpriteBuilder>().chosenOther = Random.Range(0,2);
			girl.GetComponent<GirlSpriteBuilder>().chosenLegs = Random.Range(1,5);
		}

		girl4.GetComponent<GirlSpriteBuilder>().chosenBody = mainGirl.body;
		girl4.GetComponent<GirlSpriteBuilder>().chosenHead = mainGirl.head;
		girl4.GetComponent<GirlSpriteBuilder>().chosenOther = mainGirl.other;
		girl4.GetComponent<GirlSpriteBuilder>().chosenLegs = mainGirl.legs;

		girls.Add(girl4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(0.5f);
	}
}
