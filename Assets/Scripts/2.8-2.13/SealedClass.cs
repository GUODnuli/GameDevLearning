using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ܷ���
// �ܷ��಻�ܱ��̳�
// �ܷ�����Լ̳�������

public class SealedClass : MonoBehaviour
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

public sealed class MyClass8
{
    public MyClass8()
    {
        Debug.Log("MyClass constructor");
    }
}

public class MyClass9 //: MyClass8
{
    public MyClass9()
    {
        Debug.Log("MyClass9 constructor");
    }
}