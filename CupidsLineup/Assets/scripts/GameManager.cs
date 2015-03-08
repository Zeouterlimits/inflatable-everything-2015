using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public string correctLass;

	private Person mainGirl;
	private List<Person> peopleList;
	private List<Person> peopleDone;
	private int maxPeople = 4;
	private int currentStreak = 0;

	private static GameManager instance = null;
	
	public static GameManager Instance {
		get { return instance; }
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	public int getCurrentWinStreak() {
		return currentStreak;
	}

	public void incrementCurrentWinStreak() {
		currentStreak++;
	}

	public void resetCurrentWinStreak() {
		currentStreak = 0;
	}

	public void stopMusic() {
		PersistAudio.Instance.Destroy ();
	}

	public List<Person> getPeopleDone() {
		if (peopleDone == null) {
			resetPeopleDone();
		}
		return peopleDone;
	}

	public void addPeopleDone(Person newPerson) {
		if (peopleDone == null) {
			resetPeopleDone();
		}
		peopleDone.Add(newPerson);
	}

	public int getPeopleDoneCount() {
		if (peopleDone == null) {
			resetPeopleDone();
		}
		return peopleDone.Count;
	}

	public void resetPeopleDone() {
		peopleDone = new List<Person>();
		Debug.Log("RESETTING LIST OF PEOPLE DONE");
	}

	public int getMaxPeople() {
		return maxPeople;
	}

	public List<Person> getPeopleList() {
		if(peopleList == null) return new List<Person>();

		return peopleList;
	}

	public void setPeopleList(List<Person> newPeopleList) {
		peopleList = newPeopleList;

	}

	public Person getMainGirl() {
		if(mainGirl == null) return new Person();

		return mainGirl;
	}

	public void setMainGirl(Person newMainGirl) {
		mainGirl = newMainGirl;

	}

	public void girlChosen(string chosen) {
		if(mainGirl.personName.Equals(chosen)) {
			GameManager.Instance.incrementCurrentWinStreak();
			Application.LoadLevel("03_you_win");
		} else {
			//Resetting of the win streak is done in the lose scene, as it's needed to show the user how they did.
			Application.LoadLevel("04_you_lose");
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
