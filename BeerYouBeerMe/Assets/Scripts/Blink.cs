using UnityEngine;

public class Blink : MonoBehaviour {

	public float toggleTime = 1f;

	private SpriteRenderer spriteRenderer;
	private float lastToggle;

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		lastToggle = Time.time;
	}
	
	void Update () {
		if (Time.time > lastToggle + toggleTime) {

			spriteRenderer.enabled = !spriteRenderer.enabled;

			lastToggle = Time.time;
		}
	}
}
