using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrafficLight : MonoBehaviour
{
    public bool signal;
    // true: green
    // false: red

    public Material red;
    public Material green;
    // Start is called before the first frame update


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (signal)
            GetComponent<Renderer>().material = green;
        else
            GetComponent<Renderer>().material = red;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CarView" && !signal)
            other.gameObject.GetComponent<CarView>().isStop = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CarView" && signal)
        {
            other.gameObject.GetComponent<CarView>().isStop = false;
            //if (! other.transform.parent.GetComponent<CarMove>().rightTurnCar)
            //    other.transform.parent.GetComponent<CarMove>().speed = Random.Range(4f, 6f);
            //else
                other.transform.parent.GetComponent<CarMove>().speed = Random.Range(8f, 12f);
            other.transform.parent.GetComponent<Renderer>().material = green;
        }
    }
}
