using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmpInterfaceAbstract : MonoBehaviour
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

// 接口与抽象类的异同

// 相同点：
// 1. 不能被实例化
// 2. 可以被继承
// 3. 可以包含方法声明
// 4. 派生类必须实现接口或抽象类中的所有方法

// 不同点：
// 1. 接口中的方法不能有方法体，抽象类中的方法可以有方法体
// 2. 接口中的方法不能有访问修饰符，默认为public，抽象类中的方法可以有访问修饰符
// 3. 接口可以被多重继承，抽象类只能被单一继承

// 用法
// 抽象类更多的是用于代码的复用，接口更多的是用于代码的规范

namespace Cmp{
    public interface BaseInterface
    {
        //public int a;
        //BaseInterface();
        //static BaseInterface();
    }

    public abstract class MyAbstract
    {
        public int a;
        MyAbstract()
        {
            Debug.Log("MyAbstract");
        }
        static MyAbstract()
        {
            Debug.Log("MyAbstract static");
        }
    }
}