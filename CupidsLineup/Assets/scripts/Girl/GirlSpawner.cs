using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GirlSpawner : MonoBehaviour {

	public GameObject spriteToDuplicate;
	private List<Person> people;
	private int maxPeople;

	private List<GameObject> girls = new List<GameObject>();

	// Use this for initialization
	void Start () {
		people = GameManager.Instance.getPeopleList();
		maxPeople = GameManager.Instance.getMaxPeople();

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

		girls.Add(girl1);
		girls.Add(girl2);
		girls.Add(girl3);
		girls.Add(girl4);

		girls = mixUpList(girls);

		for(int i = 0; i < maxPeople; i++) {
    		girls[i].name = people[i].personName;
			girls[i].GetComponent<GirlSpriteBuilder>().chosenBody = people[i].body; //int random is exclusive
			girls[i].GetComponent<GirlSpriteBuilder>().chosenHead = people[i].head;
			girls[i].GetComponent<GirlSpriteBuilder>().chosenOther = people[i].other;
			girls[i].GetComponent<GirlSpriteBuilder>().chosenLegs = people[i].legs;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	List<GameObject> mixUpList (List<GameObject> girls) {
		List <GameObject> newGirls = new List<GameObject>(); 
		int initialLength = girls.Count;
		int numRands = initialLength;
	
		for(int i = 0; i < initialLength; i++) {
			int randomIndex = Random.Range(0,numRands);
			newGirls.Add(girls[randomIndex]); 
			girls.RemoveAt(randomIndex);
			numRands --;
			Debug.Log("Random pos for girl was " + randomIndex + " on iteration " + i);
		}

		return newGirls;
	}
}
