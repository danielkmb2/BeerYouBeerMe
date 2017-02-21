using UnityEngine;

public class EndGameController : MonoBehaviour {

	public GameObject taiboWinScreen;
	public GameObject antonioWinScreen;

	public string antonioPrefabName = "Antonio";
	public string taiboPrefabName = "Taibo";

	public KeyCode quitKey = KeyCode.Escape;
	public KeyCode startKey = KeyCode.Return;
	public string gameLevelName = "Game";

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
		if (Input.GetKeyDown(quitKey)) {
			Application.Quit();
		}
		if (Input.GetKeyDown(startKey)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene(gameLevelName);
		}
	}
}
