using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������
// �����಻�ܱ�ʵ����
// ֧�ֹ��캯��
// ��������Լ̳г�����
// ��̬���캯��ִֻ��һ�Σ����������Ĺ��캯������ʵ�����Ĵ���ִ��

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
