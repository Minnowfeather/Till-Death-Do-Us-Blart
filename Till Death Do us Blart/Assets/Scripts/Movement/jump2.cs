using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (Physics2D.Raycast(this.transform.position, new Vector2(0, -1), 1)) {
            print("h2");
        } else {
            print("h3");
        }
    }
}
