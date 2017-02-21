using UnityEngine;

public class TutorialController : MonoBehaviour {

	public string gameLevelName = "Game";
	public KeyCode quitKey = KeyCode.Escape;
	public KeyCode startKey = KeyCode.Return;

	void Update() {
		if (Input.GetKeyDown(quitKey)) {
			Application.Quit();
		}
		if (Input.GetKeyDown(startKey)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene(gameLevelName);
		}

	}
}
