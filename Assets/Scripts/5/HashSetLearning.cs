using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashSetLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HashSetOperation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HashSetOperation()
    {
        HashSet<string> hs = new() 
        {
            "Sam",
            "Tom",
            "Jerry"
        };

        HashSet<string> hs2 = new()
        {
            "Marry",
            "Tom",
            "John"
        };

        foreach(string s in hs)
        {
            Debug.LogFormat("Name: {0}", s);
        }

        // hs.IntersectWith(hs2); // 交集
        // hs.UnionWith(hs2); // 并集
        // hs.ExceptWith(hs2); // 差集
        hs.SymmetricExceptWith(hs2); // 对称差集
        foreach(var i in hs)
        {
            Debug.LogFormat("{0}", i);
        }
    }
}
