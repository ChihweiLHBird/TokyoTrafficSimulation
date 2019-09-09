using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTCarView : CarView
{
    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
        transform.parent.GetComponent<CarMove>().rightTurnCar = true;
    }

    // Update is called once per frame
    protected new void Update()
    {
        base.Update();
        //if (Vector3.Distance(transform.position, GameObject.Find("RightTrunNode").transform.position) < 2)
        //    transform.parent.GetComponent<CarMove>().speed = Random.Range(10f, 12f);
    }

    protected new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        
        //if (other.tag == "CarView")
        //    base.isClose = true;
    }

    protected new void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        if (other.tag == "CarView")
            base.RecoverVelocity();
    }
    //protected new void RecoverVelocity()
    //{
        //base.RecoverVelocity();
        //base.isClose = false;
        //transform.parent.GetComponent<CarMove>().speed = 4f;
        //transform.parent.GetComponent<CarMove>().speed = Random.Range(10f, 12f);
        //transform.parent.GetComponent<Renderer>().material = green;
    //}
}
