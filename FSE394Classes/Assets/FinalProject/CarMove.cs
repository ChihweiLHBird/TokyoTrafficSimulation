using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarMove : MonoBehaviour
{
    bool goThrough;
    public float speed;
    public bool rightTurnCar;
    //public float maxSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(8f, 12f);
        goThrough = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        Transform[] nodes = null;

        if (other.tag == "StreetNode") // if car hits a node
        {
            // Get a list of nodes
            nodes = other.gameObject.GetComponent<StreetNode>().nextNode;
            if (nodes == null || nodes.Length == 0) // no child case
            {
                Destroy(gameObject);
                PlayerPrefs.SetInt("CarsReachedGoal", 1 + PlayerPrefs.GetInt("CarsReachedGoal"));
                PlayerPrefs.SetInt("CarsAlive", PlayerPrefs.GetInt("CarsAlive") - 1);
            }
                
            if (!goThrough)
            {
                transform.position = other.transform.position;

                if (nodes != null && nodes.Length > 0) // link exists
                {
                    int rnd = Random.Range(0, nodes.Length);

                    Transform[] Nextnodes = nodes[rnd].GetComponent<StreetNode>().nextNode;
                    goThrough = Nextnodes == null || Nextnodes.Length == 0;

                    Vector3 dir = other.GetComponent<StreetNode>().directions[rnd];
                    GetComponent<Rigidbody>().velocity = dir * speed;
                    transform.forward = dir;
                }
            }
                
        }
    }

   /* private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Car")
        {
            speed -= 0.5f;
            if (speed < 0)
                speed = 0;
        }
    }*/
}
