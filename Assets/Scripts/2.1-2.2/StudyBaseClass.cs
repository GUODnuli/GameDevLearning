using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyBaseClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();
        int a = myClass.a;
        Debug.LogFormat("myClass.a = {0}", a);
        myClass.MyMethod();

        Debug.LogFormat("MyClass.b = {0}", MyClass.b);
        MyClass.MyStaticMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MyClass
{
    public int a = 10;
    public void MyMethod()
    {
        Debug.Log("MyMethod is called.");
    }

    public static int b = 20;
    public static void MyStaticMethod()
    {
        Debug.Log("MyStaticMethod is called.");
    }
}