using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class StringBuilderTest : MonoBehaviour
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
        StringBuilder s = new();
        Stopwatch stopwatch = new();

        stopwatch.Start();
        s.Append("Hello World");
        stopwatch.Stop();
        Debug.LogFormat("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);

        stopwatch.Start();
        s.Append("x2");
        stopwatch.Stop();
        Debug.LogFormat("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);

        Debug.LogFormat("StringBuikder.content: {0}", s);
        Debug.LogFormat("StringBuilder.Length: {0}, StringBuilder.Capacity: {1}", s.Length, s.Capacity);

        stopwatch.Start();
        s = s.AppendFormat(", Hello World {0}", "x3");
        stopwatch.Stop();
        Debug.LogFormat("Time elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);

        Debug.LogFormat("StringBuikder.content: {0}", s);
        Debug.LogFormat("StringBuilder.Length: {0}, StringBuilder.Capacity: {1}", s.Length, s.Capacity);
    }
}
