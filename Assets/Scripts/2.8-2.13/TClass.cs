using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass15<int> myClass = new MyClass15<int>(10);
        myClass.Set(0, 10);
        myClass.Set(1, 20);

        Debug.LogFormat("\nmyClass.Get(0) = {0}, myClass.Get(1) = {1}", myClass.Get(0), myClass.Get(1));

        MyClass15<string> myClass2 = new MyClass15<string>(10);
        myClass2.Set(0, "Hello");
        myClass2.Set(1, "World");

        Debug.LogFormat("\n{0}, {1}.", myClass2.Get(0), myClass2.Get(1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MyClass15<T>
{
    private T[] m_array;

    public MyClass15(uint size)
    {
        m_array = new T[size];
    }

    public void Set(uint index, T value)
    {
        m_array[index] = value;
    }

    public T Get(uint index)
    {
        return m_array[index];
    }
}