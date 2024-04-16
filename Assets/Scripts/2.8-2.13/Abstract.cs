using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 抽象类
// 抽象类不能被实例化
// 支持构造函数
// 抽象类可以继承抽象类
// 静态构造函数只执行一次；但是其他的构造函数根据实例化的次数执行

public class Abstract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyNamespace2.MyClass3 myClass3 = new MyNamespace2.MyClass3();
        MyNamespace2.MyClass3 myClass4 = new MyNamespace2.MyClass3();
        myClass3.MyMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

namespace MyNamespace2
{
    public abstract class MyClass
    {
        public MyClass()
        {
            Debug.Log("MyClass constructor called.");
        }

        static MyClass()
        {
            Debug.Log("MyClass Static constructor called.");
        }

        public abstract void MyMethod();
    }

    public abstract class MyClass2 : MyClass
    {
        public override void MyMethod()
        {
            Debug.Log("MyClass2 MyMethod called.");
        }
    }

    public class MyClass3 : MyClass2
    {
        public MyClass3()
        {
            Debug.Log("MyClass3 constructor called.");
        }
    }
}
