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

// �ӿ�����������ͬ

// ��ͬ�㣺
// 1. ���ܱ�ʵ����
// 2. ���Ա��̳�
// 3. ���԰�����������
// 4. ���������ʵ�ֽӿڻ�������е����з���

// ��ͬ�㣺
// 1. �ӿ��еķ��������з����壬�������еķ��������з�����
// 2. �ӿ��еķ��������з������η���Ĭ��Ϊpublic���������еķ��������з������η�
// 3. �ӿڿ��Ա����ؼ̳У�������ֻ�ܱ���һ�̳�

// �÷�
// ���������������ڴ���ĸ��ã��ӿڸ���������ڴ���Ĺ淶

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