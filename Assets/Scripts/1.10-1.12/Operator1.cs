using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator1 : MonoBehaviour
{
    static A GetA()
    {
        return new A();
    }
    // Start is called before the first frame update
    void Start()
    {
        ModFunction();
        AddFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ModFunction()
    {
        int a = 10;
        int b = 3;
        int c = a % b;
        Debug.LogFormat("a % b = {0}", c);
    }

    void AddFunction()
    {
        int a = 10;
        int b = 3;
        int c = a + b;
        Debug.LogFormat("a + b = {0}", c);
    }
}


public class A
{
    public static A operator +(A a, A b)
    {
        return new A();
    }

    public static A operator -(A a, A b)
    {
        return new A();
    }

    public static A operator *(A a, A b)
    {
        return new A();
    }

    public static A operator /(A a, A b)
    {
        return new A();
    }

    public static A operator %(A a, A b)
    {
        return new A();
    }
}
