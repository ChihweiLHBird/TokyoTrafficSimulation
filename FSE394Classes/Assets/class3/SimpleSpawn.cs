using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawn : MonoBehaviour
{
    public Transform prefabAgent;
    int step = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step++;
        if (step == 90)
        {
            step = 0;
            Transform a0 = Instantiate(prefabAgent, transform.position, Quaternion.identity);
            Transform a1 = Instantiate(prefabAgent, transform.position, Quaternion.identity);
            Transform a2 = Instantiate(prefabAgent, transform.position, Quaternion.identity);
        }
    }
}
