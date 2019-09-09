using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgentGeneratingControl : MonoBehaviour
{
    public Transform[] agentGenerators;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform generator in agentGenerators)
            generator.GetComponent<AgentGenerator>().spawningTime_Agents = (1 / GetComponent<Slider>().value * 13);
    }
}
