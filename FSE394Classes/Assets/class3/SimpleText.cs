using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SimpleText : MonoBehaviour
{
    Text message;
    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        message.text = Time.time.ToString("F2");
    }
}
