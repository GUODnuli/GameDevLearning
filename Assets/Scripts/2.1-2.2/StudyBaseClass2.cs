using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyBaseClass2 : MonoBehaviour
{
    MyNamespace.MyClass myClass;
    // Start is called before the first frame update
    void Start()
    {
        myClass = new MyNamespace.MyClass();
        int a = myClass.a;
    }

    // Update is called once per frame
    void Update()
    {
        // Input 是一个监听鼠标键盘输入的类
        if (Input.GetMouseButtonDown(0)) // 0 button is left button, 1 is right button, 2 is middle button
        {
            Destroy(this.gameObject);
        }
    }
}

namespace MyNamespace
{
    public class MyClass
    {
        public int a = 10;

        public MyClass()
        {
            Debug.Log("MyNamespace::MyClass's constructor is called.");
        }

        ~MyClass()
        {
            Debug.Log("MyNamespace::MyClass's destructor is called.");
        }
        public void MyMethod()
        {
            Debug.Log("MyNamespace::MyMethod is called.");
        }

        public static int b = 20;
        public static void MyStaticMethod()
        {
            Debug.Log("MyNamespace::MyStaticMethod is called.");
        }
    }

}