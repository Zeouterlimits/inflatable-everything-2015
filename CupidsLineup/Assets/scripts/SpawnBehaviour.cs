using UnityEngine;
using System.Collections;

public class SpawnBehaviour : MonoBehaviour {

	//public GameObject spriteToDuplicate;

	// Use this for initialization
	void Start () {
		//Vector3 currentPosition = spriteToDuplicate.transform.position;
		float horizontalPosition = 20f;
		for(int i = 0; i < 10; i++)
		{
			//GameObject tmpObj = GameObject.Instantiate(spriteToDuplicate,currentPosition,Quaternion.identity) as GameObject;
			//currentPosition += new Vector3(horizontalPosition,0f,0f);
			horizontalPosition  += 20f;
			wait ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(0.2f);
	}
}
