using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentGenerator : MonoBehaviour
{

    public Transform prefab;
    //private int step = 0;
    private float time = 0;
    public float spawningTime_Agents;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("agentsDestoried", 0);
        PlayerPrefs.SetInt("AgentsGenerated", 0);
        PlayerPrefs.SetInt("AgentsAlive", 0);
        //Time.timeScale = 1f;
        spawningTime_Agents = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawningTime_Agents)
        {
            for (int i = 0; i < 3; i++)
            {
                //Quaternion x = Quaternion.Euler(new Vector3(0, Random.Range(0f, 360f), 0));
                Debug.Log("Created");
                Transform temp = Instantiate(prefab, transform.position, Quaternion.identity);
                temp.GetComponent<Rigidbody>().useGravity = false;
                temp.GetComponent<Collider>().isTrigger = true;
                PlayerPrefs.SetInt("AgentsGenerated", 1 + PlayerPrefs.GetInt("AgentsGenerated"));
                PlayerPrefs.SetInt("AgentsAlive", 1 + PlayerPrefs.GetInt("AgentsAlive"));
            }
            time = 0;
        }
    }
}
