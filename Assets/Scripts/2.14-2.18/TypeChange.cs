using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ǰ��֪ʶ
//   �������ͺ�ֵ����
//     �������ͣ��ࡢ�ӿڡ�ί�С����顢String
//     ֵ���ͣ��ṹ��ö�١������������͡��Զ���Ľṹ

// is �� as �����
//  is ��������ڼ������Ƿ����ض����͵�ʵ��
//  as ���������ת���������͡����ת���ɹ����� as ���������ת����Ķ��󣬷��򷵻� null
//  ���߶�����������ת���ģ����� is ����������ж������Ƿ���ͬ��as �������������ת��
// ǿ������ת������ʽ����ת��
//  ǿ������ת����ǿ������ת����ָ��ת����������ʱ����Ҫʹ��ǿ������ת������ǿ������ת���������û������ת��������ʵ�ֵ�
//    1. �߾��� -> �;��� �� ��ע�⾫�ȶ�ʧ�����ܻᵼ�����������

//  ��ʽ����ת������ʽ����ת����ָ����Ҫʹ��ǿ������ת���������������Զ���������ת��
public class TypeChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 123;
        short b = (short)a;  // ǿ������ת��
        Debug.Log(b);

        short c = 1234;
        int d = c;  // ��ʽ����ת��
        Debug.Log(d);

        // short e = 32768;

        bool f = a is string;
        Debug.Log(f);

        //string g = a as string;
        //Debug.Log(g);

        // asͨ�������ж�ĳһ������������Ƿ�����һ�����������
        ChildClass objTemp = new ChildClass();

        if (objTemp as ChildClass != null)
        {
            Debug.Log("objTemp is ChildClass");
        }

        if (objTemp as FatherClass != null)
        {
            Debug.Log("objTemp is FatherClass");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class FatherClass
{

}

public class ChildClass : FatherClass
{

}