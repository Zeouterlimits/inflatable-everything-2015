using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public string correctLass;

	private Person mainGirl;

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

	public Person getMainGirl() {
		if(mainGirl == null) return new Person();

		return mainGirl;
	}

	public void setMainGirl(Person newMainGirl) {
		mainGirl = newMainGirl;

	}

	public void girlChosen(string chosen) {
		if(mainGirl.personName.Equals(chosen)) {
			Application.LoadLevel("03_youWin");
		} else {
			Application.LoadLevel("04_youLose");
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
