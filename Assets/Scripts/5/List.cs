using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ListOperations();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ListOperations()
    {
        List<int> list1 = new();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);

        foreach (int i in list1)
        {
            Debug.LogFormat("list1: {0}", i);
        }
    }
}
