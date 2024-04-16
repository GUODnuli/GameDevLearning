using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass2.MyMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// 静态构造函数
// 静态构造函数是在类被加载的时候调用的，而且只会被系统调用一次
// 静态构造函数没有访问修饰符，也没有参数

// 静态类
// 静态类不能被实例化，不能被继承
// 静态类只能包含静态成员
// 静态类不能包含实例构造函数, 但可以包含一个静态构造函数（暂时记录：静态类的静态构造函数，经测试发现，并不会执行）

public static class MyClass2
{
    public static int mValue = 0;
    public const int mValue1 = 1;
    static MyClass2()
    {
        Debug.Log("Static constructor called.");
    }

    public static void MyMethod()
    {
        Debug.Log("MyMethod called.");
    }
}

//public static class MyClass1: MyClass 静态类不能被继承
//{

//}
