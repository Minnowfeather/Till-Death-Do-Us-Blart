using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rogueMove : MonoBehaviour {

	private float x;
	private float y;
	private Rigidbody2D body;
	private Vector3 v;
	// Use this for initialization
	void Start () {
		x = 0.0f;
		y = 0.0f;
		body = this.GetComponent<Rigidbody2D>();
		v = new Vector3(0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a"))
		{
			x -= 0.25f;
		}
		if (Input.GetKey("d"))
		{
			x += 0.25f;
		}
		if (Input.GetKey("w"))
		{
			y += 0.25f;
		}
		if (Input.GetKey("s"))
		{
			y -= 0.25f;
		}
		v = new Vector3(x, y, 0.0f);
		body.transform.position += v;
		x = 0;
		y = 0;
	}
}
