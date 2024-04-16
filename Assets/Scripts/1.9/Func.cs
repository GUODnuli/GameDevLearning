using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

// 1.函数返回值的分类
// 1.1. 无返回值 void FunctionName () {}
// 1.2. 有返回值 type FunctionName () { return value; }

// 2.函数调用

// 3.如何调试程序
// 3.1.断点如何添加
// 3.1.1选中任意行代码，按F9
// 3.1.2.在左侧的行号区域，点击鼠标右键，选择Toggle Breakpoint
// 3.2.如何调试
// 3.2.1.按F5启动调试
// 3.2.2.附加到Unity进程，同时启动Unity
// 3.2.3.F11进入函数体内，F10单步执行，F5继续执行，Shift+F11退出函数体

public class Func : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string strMonsterName = "Goblin";
        int iMonsterHealth = 100;
        int ilevel = 5;
        long lExperience = 1000;
        ShowContxt();
        ShowMonsterInfo(strMonsterName, ilevel, iMonsterHealth, lExperience);

        int iSum = getSummation(1, 2);
        Debug.LogFormat("The summation of 1 and 2 is {0}", iSum);
        Debug.LogFormat("The summation of 1 and 2 is {0}", iSum);
    }

    // Update is called once per frame
    void Update()
    {
        //ShowContxt();
    }

    void ShowContxt()
    {
        Debug.LogFormat("This is a function without return value");
    }

    void ShowMonsterInfo(string strName, int iHealth, int ilevel, long lExperience)
    {
        Debug.LogFormat("\nMonster Name: {0}\nHealth: {1}\nLevel: {2}\nExperience:{3}", strName, iHealth, ilevel, lExperience);
    }

    int getSummation(int ia, int ib)
    {
        int sum = ia + ib;
        return sum;
    }
}
