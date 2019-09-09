using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetNode : MonoBehaviour
{
    public Transform[] nextNode;
    public Vector3[] directions;
    // Start is called before the first frame update
    void Start()
    {

        if (nextNode == null || nextNode.Length == 0)
            return;
        directions = new Vector3[nextNode.Length];
        for (int i = 0; i < nextNode.Length; i++)
            directions[i] = Vector3.Normalize(nextNode[i].position - transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
