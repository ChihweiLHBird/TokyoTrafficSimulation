using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarGeneratingControl : MonoBehaviour
{
    public Transform[] carGenerators;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform generator in carGenerators)
            generator.GetComponent<CarSpawn>().spawningTime_Cars = (1 / GetComponent<Slider>().value * 10);
    }
}
