using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HashTableOperation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HashTableOperation()
    {
        Hashtable ht1 = new();
        ht1.Add("1", 100);
        ht1.Add(1, 99);
        ICollection key = ht1.Keys;
        foreach(var i in key)
        {
            Debug.Log(ht1[i]);
        }
        ht1.Clear();
    }
}
