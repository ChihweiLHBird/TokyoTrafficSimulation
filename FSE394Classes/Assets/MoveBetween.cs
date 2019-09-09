using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetween : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetA;
    public Transform targetB; //which this code attached to
    float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = (float) (Mathf.Cos(2 * Mathf.PI * Time.time*speed) * 0.5 + 0.5);
        transform.position = (1 - t) * targetA.position + t * targetB.position;
    }
}
