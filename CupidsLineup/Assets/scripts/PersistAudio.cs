using UnityEngine;
using System.Collections;

public class PersistAudio : MonoBehaviour {

	private static PersistAudio instance = null;

	public static PersistAudio Instance {
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
}
