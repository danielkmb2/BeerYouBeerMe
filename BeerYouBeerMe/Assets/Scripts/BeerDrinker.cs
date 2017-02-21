using UnityEngine;

public class BeerDrinker : MonoBehaviour {

	public int beers = 0;
	public string beerTag = "Beer";

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.CompareTag(beerTag)) {
			beers += 1;
			Destroy(collision.gameObject);
		}
	}
}
