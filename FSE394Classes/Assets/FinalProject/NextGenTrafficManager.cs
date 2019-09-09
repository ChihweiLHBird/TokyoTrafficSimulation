using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGenTrafficManager : MonoBehaviour
{
    public Transform[] carTrafficLight;
    public Transform[] PedeCrossing;
    public Transform[] PedeSignalLight;
    private bool CarGturnR;
    private int trafficState;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        CarGturnR = false;
        foreach(Transform i in PedeCrossing)
            i.GetComponent<PedestrianCrossing>().signal = true;
        foreach (Transform i in PedeSignalLight)
            i.GetComponent<PedestrianTrafficLight>().signal = true;
        foreach (Transform i in carTrafficLight)
            i.GetComponent<CarTrafficLight>().signal = false;
        trafficState = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        switch (trafficState)
        {
            case 1:
                BothRed();
                break;
            case 2:
                CarGreenTurnRed();
                break;
            case 3:
                CarRedTurnGreen();
                break;
            default:
                Debug.Log("Traffic Control Error!");
                break;
        }
    }
    void CarRedTurnGreen()
    {
        if (time >= 5)
        {
            foreach (Transform i in PedeCrossing)
                i.GetComponent<PedestrianCrossing>().signal = false;
            foreach (Transform i in PedeSignalLight)
                i.GetComponent<PedestrianTrafficLight>().signal = false;
            foreach (Transform i in carTrafficLight)
                i.GetComponent<CarTrafficLight>().signal = true;
            CarGturnR = !CarGturnR;

            time = 0;
            trafficState = 1;
        }
    }

    void CarGreenTurnRed()
    {
        if (time >= 5)
        {
            foreach (Transform i in PedeCrossing)
                i.GetComponent<PedestrianCrossing>().signal = true;
            foreach (Transform i in PedeSignalLight)
                i.GetComponent<PedestrianTrafficLight>().signal = true;
            foreach (Transform i in carTrafficLight)
                i.GetComponent<CarTrafficLight>().signal = false;
            CarGturnR = !CarGturnR;

            time = 0;
            trafficState = 1;
        }
        
    }

    void BothRed()
    {
        if (time >= 15)
        {
            foreach (Transform i in PedeCrossing)
                i.GetComponent<PedestrianCrossing>().signal = false;
            foreach (Transform i in PedeSignalLight)
                i.GetComponent<PedestrianTrafficLight>().signal = false;
            foreach (Transform i in carTrafficLight)
                i.GetComponent<CarTrafficLight>().signal = false;

            if (CarGturnR)
                trafficState = 2;
            else
                trafficState = 3;

            time = 0;
        }
    }
}
