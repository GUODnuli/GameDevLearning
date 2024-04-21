using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DirectoryTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string assetsPath = Application.dataPath;
        string projectPath = Application.persistentDataPath;
        string folderpath = assetsPath + "/Resources/TestFolder";

        CreateFolder(folderpath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateFolder(string folderpath)
    {
        try {
            if (!System.IO.Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }
            else
            {
                throw new System.IO.IOException("Folder Already Exists");
            }
        }
        catch (System.IO.IOException e)
        {
            Debug.LogError(e.Message);
        }
    }
}
