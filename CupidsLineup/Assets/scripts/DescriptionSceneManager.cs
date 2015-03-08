using UnityEngine.UI;
using UnityEngine;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DescriptionSceneManager : MonoBehaviour {

	Text countDownText;
	Text girlDescText;
	Text girlNameText;
	Text girlFeedText1;
	Text girlFeedText2;
	Text girlFeedText3;
    List<Person> peopleArray = new List<Person>();
    List<Person> peopleDone = new List<Person>();
    Person mainGirl;
	string[] randomFeedItems = {"Weather is perfect for a walk!", ":( it's raining again!", "I hate mondays..", "Just won a Game Jam, so happy!"};
	float startTime;
	int countDownTime;
	int currentTime;
	int lastKnownTime;
	int maxPeople;

	public float difficultyTimeDecider = 3f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		lastKnownTime = (int) startTime;
		countDownTime = (int)difficultyTimeDecider + 1;
		countDownText = GameObject.Find("Desc_countDownText").GetComponent<Text>();
		girlDescText = GameObject.Find("Desc_DescText").GetComponent<Text>();
		girlNameText = GameObject.Find("Desc_NameText").GetComponent<Text>();
		girlFeedText1 = GameObject.Find("Desc_FeedText1").GetComponent<Text>();
		girlFeedText2 = GameObject.Find("Desc_FeedText2").GetComponent<Text>();
		girlFeedText3 = GameObject.Find("Desc_FeedText3").GetComponent<Text>();
		maxPeople = GameManager.Instance.getMaxPeople();
		PopulatePeopleArrayAndTrim();
		int randomGirl = Random.Range(0, maxPeople); //Max 4 girls
		Debug.Log("Random number was " + randomGirl);

		if(GameManager.Instance.getPeopleDoneCount() == maxPeople) {
		    GameManager.Instance.resetPeopleDone();
		}

		peopleDone = GameManager.Instance.getPeopleDone();

		mainGirl = peopleArray[randomGirl];

		while(peopleDone.Contains(mainGirl)) {
		    randomGirl = Random.Range(0, maxPeople); //Max 4 girls
		    mainGirl = peopleArray[randomGirl];
		}

		GameManager.Instance.addPeopleDone(mainGirl);

		Debug.Log(mainGirl.personName + " was selected");
		//GameObject gameManager = GameObject.Find("GameManager");
		GameManager.Instance.setMainGirl(mainGirl);
		GameManager.Instance.setPeopleList(peopleArray);
		
		LoadDescription(mainGirl);
	}

	void Update() {
		currentTime = (int) Time.time;
		if(currentTime > lastKnownTime && currentTime != lastKnownTime) {
			lastKnownTime = currentTime;
			countDownTime--;
			countDownText.text = countDownTime.ToString();
		}
		if(Time.time - startTime > difficultyTimeDecider) {
			Application.LoadLevel("02_lineup");
		}
	}

	IEnumerator wait() {
		yield return new WaitForSeconds(3);
	}

	void LoadDescription(Person girl) {
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

		for(int i = 0; i < peopleArray.Count; i++) {
			if(peopleArray[i].personName.Equals(name)) {
		        return peopleArray[i].description;
			}
		}
		return "I suck at writing descriptions, lol!";
	}

	void PopulatePeopleArrayAndTrim(){
		PopulatePeopleArray();
		TrimPeopleArray(maxPeople);
	}
	void PopulatePeopleArray(){
		XmlSerializer deserialiser = new XmlSerializer(typeof(List<Person>));
		TextAsset descXMLTextAsset = (TextAsset)Resources.Load("descriptions", typeof(TextAsset)); 
		TextReader descReader = new StringReader(descXMLTextAsset.text);
		peopleArray = (List<Person>)deserialiser.Deserialize(descReader);
		descReader.Close();
	}
	void TrimPeopleArray(int maxPeople) {
		int maxRand = peopleArray.Count;
		while(peopleArray.Count > maxPeople) {
			peopleArray.RemoveAt(Random.Range(0, maxRand));
			maxRand --;
		}
	}
}
