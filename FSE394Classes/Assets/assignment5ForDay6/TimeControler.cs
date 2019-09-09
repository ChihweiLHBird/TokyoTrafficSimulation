using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControler : MonoBehaviour
{
    // Start is called before the first frame update
    public void StopTime()
    {
        GameObject.Find("SliderTimeControl").GetComponent<SliderTimeControl>().timeWasStopped = true;
        Time.timeScale = 0f;
    }
    public void ResumeTime()
    {
        GameObject.Find("SliderTimeControl").GetComponent<SliderTimeControl>().timeWasStopped = false;
    }
    public void ChangeTimeScale(float new_timeScale)
    {
        Time.timeScale = new_timeScale;
    }
}
