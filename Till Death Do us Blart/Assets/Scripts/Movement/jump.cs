using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	private Vector2 v;
	private float force;
	private Rigidbody2D body;
	private float oldBodyY;
	// Use this for initialization
	void Start () {
		v = new Vector2 (0.0f, 0.0f);
		force = 0.0f;
		body = this.GetComponent<Rigidbody2D>();
		oldBodyY = body.position.y;
	}

	// Update is called once per frame
	void Update () {
		if ((Input.GetKey ("space")) && (body.position.y == oldBodyY)) {
			force += 5;
		}
		v = new Vector2 (0.0f, force);
		body.AddForce (v, ForceMode2D.Impulse);
		force = 0;
		oldBodyY = body.position.y;

	}
}
