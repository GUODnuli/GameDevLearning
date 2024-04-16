using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ģʽ
//   1. ʵ��ȫ��Ψһ
//      static���캯���������ʵ������ȫ�֣��������������
//   2. ʵ��ֻ��������ڲ�����
//      �����캯��˽�л����ⲿ�޷�����ʵ����
//   3. ��Ҫ�ṩһ��ȫ�ַ��ʵ�
public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //MySingleton mySingleton1 = new MySingleton();
        //MySingleton mySingleton2 = new MySingleton();
        //MySingleton mySingleton3 = new MySingleton();

        //Debug.LogFormat("Single1.HashCode = {0}", mySingleton1.GetHashCode());
        //Debug.LogFormat("Single2.HashCode = {0}", mySingleton2.GetHashCode());
        //Debug.LogFormat("Single3.HashCode = {0}", mySingleton3.GetHashCode());
        MySingleton single1 = MySingleton.Instance;
        single1.Show();

        MySingleton single2 = MySingleton.Instance;
        single2.Show();

        Debug.LogFormat("Single1.HashCode = {0}", single1.GetHashCode());
        Debug.LogFormat("Single2.HashCode = {0}", single2.GetHashCode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MySingleton
{
    private static MySingleton _instance;
    public static MySingleton Instance
    {
        get
        {
            _instance ??= new MySingleton();
            return _instance;
        }
    }
    private MySingleton()
    {
        Debug.Log("MySingleton is created.");
    }

    public void Show()
    {
        Debug.Log("Show is called.");
    }
}