using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
            pos.z += 0.5f;
        if (Input.GetKey("s"))
            pos.z -= 0.5f;
        if (Input.GetKey("a"))
            pos.x += 0.5f;
        if (Input.GetKey("d"))
            pos.x += 0.5f;
        transform.position = pos;
    }
}
