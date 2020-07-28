using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2 : MonoBehaviour
{

    GameObject player;
    bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Test Obj");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && onGround) {
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 15f, ForceMode2D.Impulse);
        }
    }

    void OnCollisionStay2D (Collision2D col)
    {
        RaycastHit2D r = Physics2D.Raycast(this.transform.position, Vector2.down, 1);
        /*print(r.fraction);*/
        /*if (r.fraction > 0) {
            print("collided");
        }
        else {
            print(r.fraction);
        }*/
        onGround = r.fraction > 0;
    }
}
