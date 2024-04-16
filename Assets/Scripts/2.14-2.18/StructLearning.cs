using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 结构体
// 可以带有方法、字段、属性、索引器、操作符方法、事件和事件处理程序
// 可以定义构造函数，但不能定义析构函数。不能定义无参构造函数。
// 不能继承其他类或结构，但可以实现一个或多个接口
// 不能作为其他结构或者类的基础结构
// 成员不能指定为abstract、virtual、protected或protected internal
// 结构体不用通过new来创建实例

public class StructLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

struct MyStruct
{
    // public MyStruct() { };   不可以定义无参构造函数
    // ~MyStruct() { }  不可以定义析构函数
    static MyStruct() { }  // 可以定义静态构造函数
    public int x;
    public int y;

    public MyStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Print()
    {
        Debug.Log("x: " + x + ", y: " + y);
    }
}