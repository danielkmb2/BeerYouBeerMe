using UnityEngine;

public class ScoreController : MonoBehaviour {
	public string endLevelName = "EndScreen";
	public int endGameScore = 20;
	public GameObject p1;
	public GameObject p2;

	private BeerDrinker p1Score;
	private BeerDrinker p2Score;
	private BeerSpawn beerSpawn;

	void Start () {
		p1Score = p1.GetComponent<BeerDrinker>();	
		p2Score = p2.GetComponent<BeerDrinker>();	
		beerSpawn = GetComponent<BeerSpawn>();	
	}
	
	void Update () {
		if (p1Score.beers == endGameScore) {
			EndGame(p1);
		}
		if (p2Score.beers == endGameScore) {
			EndGame(p2);
		}
	}

	private void EndGame(GameObject winner) {
		beerSpawn.enabled = false;
		PlayerPrefs.SetString("winner", winner.name);
		UnityEngine.SceneManagement.SceneManager.LoadScene(endLevelName);

	}
}
