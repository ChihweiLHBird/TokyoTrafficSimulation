using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarView : MonoBehaviour
{
    // Start is called before the first frame update
    // attach this to carview object

    public bool isClose = false;
    public bool isStop = false;
    public Material red;
    public Material green;
    protected GameObject other_tobechecked;
    public bool nullgameobj = false;
    protected void Start()
    {
        transform.parent.GetComponent<CarMove>().rightTurnCar = false;
        other_tobechecked = null;
    }

    // Update is called once per frame
    protected void Update()
    {
        nullgameobj = other_tobechecked == null;
        if (other_tobechecked == null)
            RecoverVelocity();

        if (isClose || isStop)
        {
            transform.parent.GetComponent<CarMove>().speed = 0;
            transform.parent.GetComponent<Renderer>().material = red;
        }
    }

    protected void OnTriggerEnter(Collider other)
    {
        other_tobechecked = other.gameObject;
        //bool isRightTurnCar = false;
        if (other.tag == "Car")
        {
            isClose = true;
            //isRightTurnCar = other.GetComponent<CarMove>().rightTurnCar;
        }
        else if (other.tag == "agent")
        {
            isClose = true;
        }

        //else if (other.tag == "CarView")
       //     transform.parent.GetComponent<CarMove>().speed *= 0.5f;
    }

    protected void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car" || other.tag == "agent")
        {
            //transform.parent.GetComponent<CarMove>().speed = Random.Range(2.0f, 5.0f);
            RecoverVelocity();
        }
    }
    protected void RecoverVelocity()
    {
        isClose = false;
        //transform.parent.GetComponent<CarMove>().speed = 4f;
        transform.parent.GetComponent<CarMove>().speed = Random.Range(8f, 12f);
        transform.parent.GetComponent<Renderer>().material = green;
    }
}
