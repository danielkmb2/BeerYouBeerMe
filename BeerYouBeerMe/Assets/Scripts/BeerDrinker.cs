using UnityEngine;

public class BeerDrinker : MonoBehaviour {

	public AudioClip burp;

	public int beers = 0;
	public string beerTag = "Beer";

	private AudioSource burpEmmiter;

	void Start() {
		burpEmmiter = GetComponent<AudioSource>();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.CompareTag(beerTag)) {
			beers += 1;
			burpEmmiter.PlayOneShot(burp);
			Destroy(collision.gameObject);
		}
	}
}
