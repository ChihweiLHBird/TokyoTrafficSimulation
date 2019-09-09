using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SimpleNav : MonoBehaviour
{
    public GameObject trafficLight;
    public Transform goal;
    public Material green;
    //public GameObject database;
    // Start is called before the first frame update
    void Start()
    {
        //goal = GameObject.Find("goal").transform;

        GameObject[] goals = GameObject.FindGameObjectsWithTag("goal");
        goal = goals[Random.Range(0, goals.Length)].transform;

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, goal.position);
        if (dis < 0.8)
        {
            Destroy(gameObject);
            //database.GetComponent<Database>().Add_agents_reachGoal();
            TextHandler.agents_number += 1;
        }
    }
}
