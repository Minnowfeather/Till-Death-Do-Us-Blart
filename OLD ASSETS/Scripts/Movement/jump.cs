using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	private Vector2 v;
	private float force;
	private Rigidbody2D body;
	private bool canJump;
	//private float timer;
	// Use this for initialization
	void Start () 
	{
		v = new Vector2 (0.0f, 0.0f);
		force = 0.0f;
		body = this.GetComponent<Rigidbody2D>();
		canJump = false;
		//timer = 0.0f;
	}

	void OnCollisionStay2D(Collision2D col)
	{
		GameObject child = col.gameObject.transform.Find("CollisionBox").gameObject;
		if (child.tag == "floor") {
			canJump = true;
		}

		// print (col.gameObject.tag);
	}

	void OnCollisionExit2D(Collision2D col)
	{
		canJump = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if ((Input.GetKey ("space")) && (canJump)) {
			force = 3*body.mass;
		}
		if (!canJump) {
			force = 0.0f;
		}
	}

	void FixedUpdate()
	{
		print (force);
		v = new Vector2 (0.0f, force);
		body.AddForce (v, ForceMode2D.Impulse);
	}
}
