using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    //public int step = 0;
    private float time = 0;
    public Transform prefabCar;
    bool isStuck;
    public float spawningTime_Cars;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CarsReachedGoal", 0);
        PlayerPrefs.SetInt("CarsGenerated", 0);
        PlayerPrefs.SetInt("CarsAlive", 0);
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("CarsAlive"));
        time += Time.deltaTime; 
        if (time > spawningTime_Cars && !isStuck)
        {
            Transform c = Instantiate(prefabCar, transform.position, transform.rotation);
            PlayerPrefs.SetInt("CarsGenerated", 1 + PlayerPrefs.GetInt("CarsGenerated"));
            PlayerPrefs.SetInt("CarsAlive", 1 + PlayerPrefs.GetInt("CarsAlive"));
            time = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
            isStuck = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Car")
            isStuck = false;
    }
}
