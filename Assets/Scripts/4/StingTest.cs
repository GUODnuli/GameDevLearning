using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StingTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Test()
    {
        string str1 = "Hello World";
        string str2 = "Hello World x 2";
        Debug.LogFormat("str: {0}, str's lenght:{1}", str1, str1.Length);
        
        int cmpresult = string.Compare(str1, str2);
        Debug.LogFormat("cmpresult: {0}", cmpresult);
    }
}
