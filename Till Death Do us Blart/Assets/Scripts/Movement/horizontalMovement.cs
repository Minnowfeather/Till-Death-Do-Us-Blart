using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovement : MonoBehaviour {

	private Vector2 v;
	private float x;
	private Rigidbody2D body;
	// Use this for initialization
	void Start () {
		v = new Vector2 (0.0f, 0.0f);
		x = 0.0f;
		body = this.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey ("a")) {
			x -= 50;
		}
		if (Input.GetKey ("d")) {
			x += 50f;
		}
		v = new Vector2 (x, 0.0f);
		body.AddForce (v);
		x = 0;

	}
}
