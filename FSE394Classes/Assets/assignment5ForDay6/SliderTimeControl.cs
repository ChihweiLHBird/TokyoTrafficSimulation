using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTimeControl : MonoBehaviour
{
    public bool timeWasStopped;
    // Start is called before the first frame update
    void Start()
    {
        timeWasStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeWasStopped)
            Time.timeScale = GetComponent<Slider>().value;
    }
}
