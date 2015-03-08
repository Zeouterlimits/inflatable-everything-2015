using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoseStreakText : MonoBehaviour {

	Text streakText;
	
	// Use this for initialization
	void Start () {
		streakText = GameObject.Find("04_you_lose_winStreakText").GetComponent<Text>();
		streakText.text = ("Your streak was " + GameManager.Instance.getCurrentWinStreak().ToString() + "!");
	}
	
	// Update is called once per frame
	void Update () {
		GameManager.Instance.resetCurrentWinStreak();
	}
}
