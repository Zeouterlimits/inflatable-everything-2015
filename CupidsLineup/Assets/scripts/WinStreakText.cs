using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinStreakText : MonoBehaviour {

	Text streakText;

	// Use this for initialization
	void Start () {
		streakText = GameObject.Find("03_you_win_winStreakText").GetComponent<Text>();
		streakText.text = ("Current streak is " + GameManager.Instance.getCurrentWinStreak().ToString() + "!");
	}
	
	// Update is called once per frame
	void Update () {

	}
}
