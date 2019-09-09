using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGUIControl : MonoBehaviour
{
    public void ExitProgram()
    {
        Application.Quit();
        
        return;
    }

    public void ShowSimulation()
    {
        
        SceneManager.LoadScene("Simulation");
        return;
    }
}
