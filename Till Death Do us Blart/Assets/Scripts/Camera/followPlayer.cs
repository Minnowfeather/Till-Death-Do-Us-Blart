using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = new Vector3(GameObject.FindWithTag("Player").transform.position.x, GameObject.FindWithTag("Player").transform.position.y, transform.position.z);
        transform.position = v;
    }
}
