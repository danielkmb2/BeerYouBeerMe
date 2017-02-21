using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidMovement : MonoBehaviour {

	public KeyCode up = KeyCode.UpArrow;
	public KeyCode down = KeyCode.DownArrow;
	public KeyCode left = KeyCode.LeftArrow;
	public KeyCode right = KeyCode.RightArrow;

	public float force = 2f;

	private Rigidbody2D body;

	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		Vector2 inputVector = getInputVector();

		body.AddForce(inputVector * force);
	}

	private Vector2 getInputVector() {
		Vector2 inputVector = Vector2.zero;

		if (Input.GetKey(up)) {
			inputVector.y += 1;
		}

		if (Input.GetKey(down)) {
			inputVector.y -= 1;
		}

		if (Input.GetKey(right)) {
			inputVector.x += 1;
		}

		if (Input.GetKey(left)) {
			inputVector.x = -1;
		}

		return inputVector;
	}
}
