using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 1. 匿名函数
// 2. event事件
// 3. 多播委托
public class Broadcast : MonoBehaviour
{
    public delegate void ShowDelegate();
    event ShowDelegate showDelegate;
    // Start is called before the first frame update
    void Start()
    {
        Action action = Show1;
        action();

        // 匿名函数
        Action action1 = delegate () { Debug.Log("Anonymous Func is called."); };
        action1();

        Action action2 = () => { Debug.Log("Anonymous Func2 is called."); };
        action2();

        // 多播委托
        // 委托属于引用类型，引用类型的默认值是null，直接使用null值的委托会报错null异常；所以在使用引用类型之前，需要检测是否为null。
        Action action3 = Show1;
        action3 += Show2;
        action3();
        action3 -= Show1;
        action3 -= Show2;
        if (action3 != null)
        {
            action3();
        }

        // event事件
        // event事件是对委托的封装，只能在类内部触发，不能在类外部触发。
        showDelegate = showgelegate;
        showDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Show1()
    {
        Debug.Log("Show1");
    }

    private void Show2()
    {
        Debug.Log("Show2");
    }

    private void showgelegate()
    {
        Debug.Log("showDelegate");
    }
}
