using UnityEngine;

public class EndGameController : MonoBehaviour {

	public GameObject taiboWinScreen;
	public GameObject antonioWinScreen;

	public string antonioPrefabName = "Antonio";
	public string taiboPrefabName = "Taibo";

	void Awake () {

		GameObject winScreen = null;
		if (PlayerPrefs.GetString("winner").Equals(antonioPrefabName)) {
			winScreen = antonioWinScreen;
		} else if (PlayerPrefs.GetString("winner").Equals(taiboPrefabName)) {
			winScreen = taiboWinScreen;
		}

		if (winScreen != null) {
			Instantiate(winScreen, Vector3.zero, Quaternion.identity);
		} else {
			Debug.Log("What the fuck bro...");
		}
	}
	
	void Update () {
		
	}
}
