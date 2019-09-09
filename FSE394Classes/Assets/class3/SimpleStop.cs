using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleStop : MonoBehaviour
{
    public GameObject trafficLight;
    float timer = 0.0f;
    public Material red;
    public Material green;
    ArrayList stoppedAgent = new ArrayList();

    private void OnTriggerEnter(Collider other)
    {
        
        if (trafficLight.GetComponent<Renderer>().sharedMaterial.color == red.color && other.tag == "agent")
        {
            other.GetComponent<NavMeshAgent>().isStopped = true;
            stoppedAgent.Add(other);
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Update_Timer());
        if (trafficLight.GetComponent<Renderer>().sharedMaterial.color == green.color && stoppedAgent.Count > 0)
        {
            foreach (object agent in stoppedAgent)
                ((Collider) agent).GetComponent<NavMeshAgent>().isStopped = false;
            stoppedAgent.Clear();
        }
    }

    int Update_Timer()
    {
        timer += Time.deltaTime;
        int seconds = (int) timer % 60;
        
        return seconds;
    }
}
