using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DictionaryLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DictionaryOperation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DictionaryOperation()
    {
        Dictionary<string, string> dictionary = new();
        dictionary.Add("Name", "Sam");
        dictionary.Add("Age", "25");
        dictionary.Add("Country", "China");

        Debug.Log(dictionary["Name"]);

        ICollection keys = dictionary.Keys;
        foreach(string key in keys)
        {
            Debug.LogFormat("Key: {0}, Value:{1}.", key, dictionary[key]);
        }
    }
}
