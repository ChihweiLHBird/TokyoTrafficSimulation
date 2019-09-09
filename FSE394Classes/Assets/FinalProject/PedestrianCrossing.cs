using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianCrossing : MonoBehaviour
{
    public bool signal;
    // true: green
    // false: red
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "agent" && !signal)
            other.GetComponent<NavMeshAgent>().isStopped = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "agent" && signal)
            other.gameObject.GetComponent<NavMeshAgent>().isStopped = false;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
