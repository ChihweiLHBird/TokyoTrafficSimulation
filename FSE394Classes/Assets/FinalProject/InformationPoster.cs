using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPoster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("thetime", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("thetime", PlayerPrefs.GetFloat("thetime") + Time.deltaTime);
        GetComponent<Text>().text =
            "Total cars generated: " + PlayerPrefs.GetInt("CarsGenerated") + "\n"
            + "Total cars reached the destinations: " + PlayerPrefs.GetInt("CarsReachedGoal") + "\n"
            + "Total cars alive in this field: " + PlayerPrefs.GetInt("CarsAlive") + "\n"
            + "Total agents generated: " + PlayerPrefs.GetInt("AgentsGenerated") + "\n"
            + "Total agents reached the destinations: " + PlayerPrefs.GetInt("agentsDestoried") + "\n"
            + "Total agents alive in this field: " + PlayerPrefs.GetInt("AgentsAlive")
            + "\n" + "Time: " + PlayerPrefs.GetFloat("thetime"); 
    }
}
