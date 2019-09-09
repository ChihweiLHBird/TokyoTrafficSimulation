using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEditor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Number of agents which reached its goal: " + PlayerPrefs.GetInt("agentsDestoried")
            + "\n" + "The time is " + Time.time;
    }
}
