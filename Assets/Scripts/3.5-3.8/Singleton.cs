using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 单例模式
//   1. 实例全局唯一
//      static构造函数，构造的实例属于全局，不属于类对象本身。
//   2. 实例只能在类的内部构造
//      将构造函数私有化，外部无法构造实例。
//   3. 需要提供一个全局访问点
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