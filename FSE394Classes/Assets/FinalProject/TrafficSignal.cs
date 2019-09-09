using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSignal : MonoBehaviour
{
    //public int step = 0;
    private float time = 0f;
    public bool signal = false;
    public Material red;
    public Material green;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "TrafficLightA")
            signal = false;
        else
            signal = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //step++;
        if (time > 10f)
        {
            //step = 0;
            time = 0;
            signal = !signal;
        }
        if (signal)
            GetComponent<Renderer>().material = green;
        else
            GetComponent<Renderer>().material = red;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CarView" && !signal)
        {
            other.gameObject.GetComponent<CarView>().isStop = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "CarView" && signal)
        {
            other.gameObject.GetComponent<CarView>().isStop = false;
            other.transform.parent.GetComponent<CarMove>().speed = Random.Range(2, 5);
            other.transform.parent.GetComponent<Renderer>().material = green;
        }
    }
}
