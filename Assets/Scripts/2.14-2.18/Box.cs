using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// װ��Ͳ���
// װ�䣺��ֵ����ת��Ϊ��������
// ���䣺����������ת��Ϊֵ����
// װ��Ͳ����Ӱ�����ܣ�������ʵ�ʿ�����Ҫ��������װ��Ͳ���
// װ��Ͳ����Ƿ�����ֵ���ͺ���������֮���ת��

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 20;
        object obj = a; // װ�䣬��ֵ����ת��Ϊ�������ͣ�װ���obj�д洢����a��ֵ��������a�ĵ�ַ
        int b = (int)obj; // ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
