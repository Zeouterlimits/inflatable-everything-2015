using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public string correctLass;

	private GirlAttrs mainGirl;

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

	public GirlAttrs getMainGirl() {
		return mainGirl;
	}

	public void setMainGirl(GirlAttrs newMainGirl) {
		mainGirl = newMainGirl;
	}

	public void girlChosen(string chosen) {
		if(correctLass.Equals(chosen)) {
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
