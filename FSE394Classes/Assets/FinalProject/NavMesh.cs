using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMesh : MonoBehaviour
{
    //public GameObject trafficLight;
    public Transform goal;
    public Material green;
    float timer;
    bool isAcidentiallyStopped;
    //public GameObject database;
    // Start is called before the first frame update
    void Start()
    {
        //goal = GameObject.Find("goal").transform;
        timer = 0;
        isAcidentiallyStopped = false;
        GameObject[] goals = GameObject.FindGameObjectsWithTag("goal");
        goal = goals[Random.Range(0, goals.Length)].transform;

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<NavMeshAgent>().isStopped)
            timer += Time.deltaTime;
        else
            timer = 0;

        if (timer >= 21 && gameObject.GetComponent<NavMeshAgent>().isStopped)
        {
            gameObject.GetComponent<NavMeshAgent>().isStopped = false;
            timer = 0;
        }
        print(GetComponent<NavMeshAgent>().isStopped);

        if (Vector3.Distance(transform.position, goal.position) < 2f)
        {
            PlayerPrefs.SetInt("agentsDestoried", PlayerPrefs.GetInt("agentsDestoried") + 1);
            PlayerPrefs.SetInt("AgentsReachedGoal", 1 + PlayerPrefs.GetInt("AgentsReachedGoal"));
            PlayerPrefs.SetInt("AgentsAlive", PlayerPrefs.GetInt("AgentsAlive") - 1);
            //Debug.Log(PlayerPrefs.GetInt("agentsDestoried"));
            Destroy(gameObject);
            /*
            try
            {
                
            }
            catch {// nothing here}
            */

        }
    }
}