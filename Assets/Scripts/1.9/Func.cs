using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

// 1.��������ֵ�ķ���
// 1.1. �޷���ֵ void FunctionName () {}
// 1.2. �з���ֵ type FunctionName () { return value; }

// 2.��������

// 3.��ε��Գ���
// 3.1.�ϵ�������
// 3.1.1ѡ�������д��룬��F9
// 3.1.2.�������к����򣬵������Ҽ���ѡ��Toggle Breakpoint
// 3.2.��ε���
// 3.2.1.��F5��������
// 3.2.2.���ӵ�Unity���̣�ͬʱ����Unity
// 3.2.3.F11���뺯�����ڣ�F10����ִ�У�F5����ִ�У�Shift+F11�˳�������

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
