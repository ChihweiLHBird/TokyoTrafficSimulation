using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTriggerMat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject correctObject;
    public GameObject targetObject;
    public Material red;
    public Material green;
    private void OnTriggerEnter(Collider other)
    {
        if (other == correctObject.GetComponent<Collider>())
        {
            //targetObject.GetComponent<Renderer>();
            print("Entered");

        }
            

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
