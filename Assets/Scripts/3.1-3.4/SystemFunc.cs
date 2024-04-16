using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SystemFunc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Func<int> func1 = GetNumber;
        Debug.Log("Number: " + func1());

        Func<int, string> func2 = GetstrNumber;
        Debug.Log(func2(20));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetNumber() { return 10; }

    string GetstrNumber(int number) { return "Name: " + number; }
}
