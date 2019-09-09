using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileIOAssi6 : MonoBehaviour
{
    string fileName;
    public GameObject trafficLight;

    public void FSE394WriteFile()
    {
        fileName = Application.dataPath + "/output.txt";
        StreamWriter sw = File.CreateText(fileName);
        //sw.WriteLine("This is my file");
        sw.WriteLine("The number of agents reached their goal is {0}", PlayerPrefs.GetInt("agentsDestoried"));
        sw.Close();
    }

    public void FSE394ReadFIle()
    {
        fileName = Application.dataPath + "/output.txt";
        StreamReader sr = null;

        if (File.Exists(fileName))
        {
            sr = File.OpenText(fileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                Debug.Log(line);
                line = sr.ReadLine();
            }
        }
        else
        {
            Debug.Log("Cannot open the file" + fileName + "for reading");
            return;
        }

        if (sr != null)
            sr.Close();
    }
}
