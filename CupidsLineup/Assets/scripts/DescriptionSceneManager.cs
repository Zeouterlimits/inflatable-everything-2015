﻿using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DescriptionSceneManager : MonoBehaviour {

	Text girlDescText;
	Text girlNameText;
	Text girlFeedText1;
	Text girlFeedText2;
	Text girlFeedText3;
	List<GirlAttrs> girlArray = new List<GirlAttrs>();
	GirlAttrs mainGirl;
	string[] randomFeedItems = {"Weather is perfect for a walk!", ":( it's raining again!", "I hate mondays..", "Just won a Game Jam, so happy!"};
	float startTime;

	public float difficultyTimeDecider = 3f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		girlDescText = GameObject.Find("Desc_DescText").GetComponent<Text>();
		girlNameText = GameObject.Find("Desc_NameText").GetComponent<Text>();
		girlFeedText1 = GameObject.Find("Desc_FeedText1").GetComponent<Text>();
		girlFeedText2 = GameObject.Find("Desc_FeedText2").GetComponent<Text>();
		girlFeedText3 = GameObject.Find("Desc_FeedText3").GetComponent<Text>();
		PopulateGirlArray();
		float randomGirl = Random.Range(0f, 1.9f);
		Debug.Log("Random number was " + randomGirl);
		mainGirl = girlArray[(int)randomGirl];
		Debug.Log(mainGirl.personName + " was selected");
		LoadDescription(mainGirl);
	}

	void Update() {
		if(Time.time - startTime > difficultyTimeDecider) {
			Application.LoadLevel("02_lineup");
		}
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(3);
	}

	void LoadDescription(GirlAttrs girl) {
		girlNameText.text = girl.personName;
		girlDescText.text = GetGirlDescFromName(girl.personName);
		//Manage feed items
		if(girl.feedItems.Length >= 3) {
			girlFeedText3.text = girl.feedItems[2];
			girlFeedText2.text = girl.feedItems[1];
			girlFeedText1.text = girl.feedItems[0];
		} else if(girl.feedItems.Length >= 2) {
			girlFeedText3.text = randomFeedItems[(int)Random.Range(0.0f, ((float)randomFeedItems.Length-0.1f))];
			girlFeedText2.text = girl.feedItems[1];
			girlFeedText1.text = girl.feedItems[0];
		} else if(girl.feedItems.Length >= 1) {
			girlFeedText3.text = randomFeedItems[(int)Random.Range(0.0f, ((float)randomFeedItems.Length-0.1f))];
			girlFeedText2.text = randomFeedItems[(int)Random.Range(0.0f, ((float)randomFeedItems.Length-0.1f))];
			girlFeedText1.text = girl.feedItems[0];
		}
	}

	string GetGirlDescFromName(string name) {

		for(int i = 0; i < girlArray.Count; i++) {
			if(girlArray[i].personName.Equals(name)) {
		        return girlArray[i].description;
			}
		}
		return "I suck at writing descriptions, lol!";
	}

	void PopulateGirlArray(){
		GirlAttrs girl1 = new GirlAttrs();
		girl1.personName = "Hannah Abbot";
		girl1.description = "I love cheese and bread and butter, with or without pickles. Balloons are my spirit animal.";
		girl1.feedItems =  new string[] {"OMG LOL I <3 CHEESE", "AMAONAZING SISTA, WELL DONE AT LIFE @ppat"};
		girlArray.Add(girl1);
		GirlAttrs girl2 = new GirlAttrs();
		girl2.personName = "Parvati Patil";
		girl2.description = "Hi I'm parvati and my favorite colour is pink. Divination 4lyf, peace out.";
		girl2.feedItems =  new string[] {"Oooh, new pibk shoes!#WinningAtLyf", "Got 100% in my Div. O.W.L.!!!!111"};
		girlArray.Add(girl2);
	}
}