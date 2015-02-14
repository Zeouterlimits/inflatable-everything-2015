using UnityEngine;
using System.Collections;

public class SpawnBehaviour : MonoBehaviour {

	public GameObject spriteToDuplicate;

	// Use this for initialization
	void Start () {
		Vector3 position1 = new Vector3(0f, 0f, 0f);
		Vector3 position2 = new Vector3(200f, 0f, 0f);
		Vector3 position3 = new Vector3(400f, 0f, 0f);
		Vector3 position4 = new Vector3(600f, 0f, 0f);

		float horizontalPosition = -100f;
		float spaceBetweenCharacters = 400f;

		for(int i = 0; i < 4; i++) {
			GameObject tmpObj = GameObject.Instantiate(spriteToDuplicate, position1, Quaternion.identity) as GameObject;
			tmpObj.GetComponent<GirlSpriteBuilder>().chosenBody = Random.Range(1,2); //int random is exclusive
			tmpObj.GetComponent<GirlSpriteBuilder>().chosenHead = Random.Range(1,4);
			tmpObj.GetComponent<GirlSpriteBuilder>().chosenOther = Random.Range(1,2);
			tmpObj.GetComponent<GirlSpriteBuilder>().chosenLegs = Random.Range(1,3);
			//Random.seed = (int) horizontalPosition;
			position1 += new Vector3(horizontalPosition,0f,0f);
			horizontalPosition  += spaceBetweenCharacters;
			wait ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(0.5f);
	}
}
