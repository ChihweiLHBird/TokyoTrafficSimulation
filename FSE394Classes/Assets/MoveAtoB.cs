using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAtoB : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Transform targetA;
    public Transform targetB; //which this code attached to
    float speed = 0.01f;
    float accel = 0.001f;
    float maxSpeed = 0.1f;
    float lengthAB;

    public bool isStation = false;
    public bool isStop = false;
    public int stopTime = 100;
    public Transform[] targets;
    public int targetID = 0;

    void Start()
    {
        targetA = targets[0];
        targetB = targets[1];
        targetID = 0;
        maxSpeed = 0.1f;
        lengthAB = Vector3.Distance(targetA.position, targetB.position);
        transform.position = targetA.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        isStation = other.tag == "Station";
    }

    //private void 
    // Update is called once per frame
    void Update()
    {
        //speed

        float dis = Vector3.Distance(transform.position, targetB.position);
        //if (dis < 0.1)
        //    speed = 0;
        if (dis < 3)
            speed -= 0.001f;
        if (speed < 0)
            speed = 0;
        //t += ((disAB - dis) + speed) / disAB;
        
        //transform.position = (1 - t) * targetA.position + t * targetB.position;
    }
}
