using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StreamTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string assetsPath = Application.dataPath;
        string projectPath = Application.persistentDataPath;
        string datapath = assetsPath + "/Resources/test2.txt";
        CreateFile(datapath);
        ReadFile(datapath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFile(string datapath)
    {
        try
        {
            StreamWriter fs = new(datapath);
            fs.WriteLine("A new Line");
            fs.WriteLine("Another new Line");
            fs.Flush();
            fs.Close();
        } 
        catch (System.Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    void ReadFile(string datapath)
    {
        try
        {
            StreamReader fs = new(datapath);
            string line;

            while ((line = fs.ReadLine()) != null)
            {
                Debug.LogFormat(line);
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.Message);
        }
    }
}
