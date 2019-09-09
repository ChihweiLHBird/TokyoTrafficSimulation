using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileIO : MonoBehaviour
{
    string fileName;
    public void FSE394WriteFile() {
        fileName = Application.dataPath + "/output.txt";
        StreamWriter sw = File.CreateText(fileName);
        sw.WriteLine("This is my file");
        sw.WriteLine("I can write ints {0} or float {1}, and so on...", 1, 4.2);
        sw.Close();
    }

    public void FSE394ReadFIle() {
        fileName = Application.dataPath + "/output.txt";
        if (File.Exists(fileName)) {
            StreamReader sr = File.OpenText(fileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                Debug.Log(line);
                line = sr.ReadLine();

            }
        }
        else {
            Debug.Log("Cannot open the file" + fileName + "for reading");
            return;
        }
    }
}
