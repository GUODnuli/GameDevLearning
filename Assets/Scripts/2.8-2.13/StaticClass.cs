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

// ��̬���캯��
// ��̬���캯�������౻���ص�ʱ����õģ�����ֻ�ᱻϵͳ����һ��
// ��̬���캯��û�з������η���Ҳû�в���

// ��̬��
// ��̬�಻�ܱ�ʵ���������ܱ��̳�
// ��̬��ֻ�ܰ�����̬��Ա
// ��̬�಻�ܰ���ʵ�����캯��, �����԰���һ����̬���캯������ʱ��¼����̬��ľ�̬���캯���������Է��֣�������ִ�У�

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

//public static class MyClass1: MyClass ��̬�಻�ܱ��̳�
//{

//}
