using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class SimButtons : MonoBehaviour
{
    string fileName;

    public void SavingResult()
    {
        fileName = Application.dataPath + "/result.txt";
        Debug.Log(fileName);
        StreamWriter sw = File.CreateText(fileName);
        //sw.WriteLine("This is my file");
        sw.WriteLine("Total cars generated: " + PlayerPrefs.GetInt("CarsGenerated"));
        sw.WriteLine("Total cars reached the destinations: " + PlayerPrefs.GetInt("CarsReachedGoal"));
        sw.WriteLine("Total cars alive in this field: " + PlayerPrefs.GetInt("CarsAlive"));
        sw.WriteLine("Total agents generated: " + PlayerPrefs.GetInt("AgentsGenerated"));
        sw.WriteLine("Total agents reached the destinations: " + PlayerPrefs.GetInt("agentsDestoried"));
        sw.WriteLine("Total agents alive in this field: " + PlayerPrefs.GetInt("AgentsAlive"));
        sw.WriteLine("Time: " + Time.time);
        sw.Close();
        Time.timeScale = 0;
        SceneManager.LoadScene("Result");
    }

}
