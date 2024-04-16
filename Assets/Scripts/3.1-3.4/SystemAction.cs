using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SystemAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Action<string> action1 = ShowName;
        action1("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowName(string strName) { Debug.Log("Name: " + strName);}
}
