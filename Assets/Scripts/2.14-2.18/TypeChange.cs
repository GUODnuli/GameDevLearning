using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 前置知识
//   引用类型和值类型
//     引用类型：类、接口、委托、数组、String
//     值类型：结构、枚举、基本数据类型、自定义的结构

// is 和 as 运算符
//  is 运算符用于检查对象是否是特定类型的实例
//  as 运算符用于转换引用类型。如果转换成功，则 as 运算符返回转换后的对象，否则返回 null
//  两者都是用于类型转换的，但是 is 运算符用于判断类型是否相同，as 运算符用于类型转换
// 强制类型转换和隐式类型转换
//  强制类型转换：强制类型转换是指在转换数据类型时，需要使用强制类型转换符，强制类型转换符是由用户定义的转换函数来实现的
//    1. 高精度 -> 低精度 ， 需注意精度丢失，可能会导致数据溢出。

//  隐式类型转换：隐式类型转换是指不需要使用强制类型转换符，编译器会自动进行类型转换
public class TypeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 123;
        short b = (short)a;  // 强制类型转换
        Debug.Log(b);

        short c = 1234;
        int d = c;  // 隐式类型转换
        Debug.Log(d);

        // short e = 32768;

        bool f = a is string;
        Debug.Log(f);

        //string g = a as string;
        //Debug.Log(g);

        // as通常用于判断某一个对象的类型是否是另一个父类的子类
        ChildClass objTemp = new ChildClass();

        if (objTemp as ChildClass != null)
        {
            Debug.Log("objTemp is ChildClass");
        }

        if (objTemp as FatherClass != null)
        {
            Debug.Log("objTemp is FatherClass");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class FatherClass
{

}

public class ChildClass : FatherClass
{

}