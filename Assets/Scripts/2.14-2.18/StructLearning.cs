using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ṹ��
// ���Դ��з������ֶΡ����ԡ����������������������¼����¼��������
// ���Զ��幹�캯���������ܶ����������������ܶ����޲ι��캯����
// ���ܼ̳��������ṹ��������ʵ��һ�������ӿ�
// ������Ϊ�����ṹ������Ļ����ṹ
// ��Ա����ָ��Ϊabstract��virtual��protected��protected internal
// �ṹ�岻��ͨ��new������ʵ��

public class StructLearning : MonoBehaviour
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

struct MyStruct
{
    // public MyStruct() { };   �����Զ����޲ι��캯��
    // ~MyStruct() { }  �����Զ�����������
    static MyStruct() { }  // ���Զ��徲̬���캯��
    public int x;
    public int y;

    public MyStruct(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Print()
    {
        Debug.Log("x: " + x + ", y: " + y);
    }
}