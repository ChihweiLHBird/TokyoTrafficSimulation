using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TraficLightControl : MonoBehaviour
{
    public Material red;
    public Material green;
    //int step = 0;
    float time = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "agent")
            other.GetComponent<NavMeshAgent>().isStopped = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //step++;
        //Debug.Log(second);
        if (time > 10f)
        {
            TurnLight();
            time = 0f;
        }
            
    }
    void TurnLight()
    {
        if (gameObject.GetComponent<Renderer>().material.color == red.color)
            gameObject.GetComponent<Renderer>().material = green;
        else
            gameObject.GetComponent<Renderer>().material = red;
    }
}
