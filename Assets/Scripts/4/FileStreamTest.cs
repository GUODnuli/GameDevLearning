using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class FileStreamTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string assetsPath = Application.dataPath;
        string projectPath = Application.persistentDataPath;
        string datapath = assetsPath + "/Resources/test.txt";

        CreateFile(datapath);
        ReadFile(datapath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFile(string datapath)
    {
        FileStream fs = new(datapath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
        string msg = "Hello World";
        byte[] bytes = Encoding.UTF8.GetBytes(msg);
        fs.Write(bytes, 0, bytes.Length);
        fs.Flush();
        fs.Close();
    }

    void ReadFile(string datapath)
    {
        if (!File.Exists(datapath))
        {
            Debug.LogError("File not found");
            return;
        }
        FileStream fs = new(datapath, FileMode.Open, FileAccess.Read, FileShare.Read);
        byte[] bytes = new byte[fs.Length];
        fs.Read(bytes, 0, bytes.Length);
        string msg = Encoding.UTF8.GetString(bytes);
        Debug.LogFormat("File content: {0}", msg);
        fs.Close();
    }
}
