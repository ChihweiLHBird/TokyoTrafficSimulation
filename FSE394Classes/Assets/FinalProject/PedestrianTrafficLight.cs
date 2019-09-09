using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianTrafficLight : MonoBehaviour
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
}
