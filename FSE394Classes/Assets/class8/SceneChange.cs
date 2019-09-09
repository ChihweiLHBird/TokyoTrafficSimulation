using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update

    public void FSE394GotoSim()
    {
        Application.LoadLevel("Sim");
    }

    public void FSE394GotoResult()
    {
        Application.LoadLevel("Result");
    }
    public void FSE394GotoTitle()
    {
        Application.LoadLevel("Title");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
