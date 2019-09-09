using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject correctObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other == correctObject.GetComponent<Collider>())
            print("Entered");

    }
    private void OnTriggerExit(Collider other)
    {
        if (other == correctObject.GetComponent<Collider>())
            print("Exit");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
