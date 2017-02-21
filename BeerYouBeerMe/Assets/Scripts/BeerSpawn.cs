using UnityEngine;

public class BeerSpawn : MonoBehaviour {

	public GameObject beerPrefab;
	public float spawnTime = 2f;
	public Boundaries boundaries;

	private float lastSpawnTime;

	[System.Serializable]
	public class Boundaries {
		public float u;
		public float d;
		public float l;
		public float r;
	}

	void Start() {
		lastSpawnTime = Time.time;
	}

	void Update () {
		if (Time.time > lastSpawnTime + spawnTime) {

			Vector2 randomPositionInBounds = GetRandomPosition();
			Quaternion randomZRotation = GetRandomZRotation();
			;

			GameObject newBeer = (GameObject)Instantiate(beerPrefab, randomPositionInBounds, randomZRotation);

			lastSpawnTime = Time.time;
		}
	}

	private Vector2 GetRandomPosition() {
		// take one random position
		Vector2 randomPosition = new Vector2(Random.Range(boundaries.l, boundaries.r), Random.Range(boundaries.u, boundaries.d));

		// are we spawning the beer over the player?
		foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player")) {
			if (Vector2.Distance(randomPosition, player.transform.position) < player.GetComponent<CircleCollider2D>().radius * 2) {
				// take another position ¯\_(ツ)_/¯
				return GetRandomPosition();
			}
		}

		return randomPosition;
	}

	private Quaternion GetRandomZRotation() {
		Quaternion randomRotation = Quaternion.identity;
		randomRotation *= Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 359)));

		return randomRotation;
	}
}
