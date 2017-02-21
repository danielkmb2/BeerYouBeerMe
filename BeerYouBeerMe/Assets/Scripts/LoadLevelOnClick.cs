using UnityEngine;

public class LoadLevelOnClick : MonoBehaviour {

	public string levelName = "Tutorial";
	public KeyCode key = KeyCode.Space;

	void Update () {
		if (Input.GetKeyDown(key)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
		}
	}
}
