using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 1. ��������
// 2. event�¼�
// 3. �ಥί��
public class Broadcast : MonoBehaviour
{
    public delegate void ShowDelegate();
    event ShowDelegate showDelegate;
    // Start is called before the first frame update
    void Start()
    {
        Action action = Show1;
        action();

        // ��������
        Action action1 = delegate () { Debug.Log("Anonymous Func is called."); };
        action1();

        Action action2 = () => { Debug.Log("Anonymous Func2 is called."); };
        action2();

        // �ಥί��
        // ί�������������ͣ��������͵�Ĭ��ֵ��null��ֱ��ʹ��nullֵ��ί�лᱨ��null�쳣��������ʹ����������֮ǰ����Ҫ����Ƿ�Ϊnull��
        Action action3 = Show1;
        action3 += Show2;
        action3();
        action3 -= Show1;
        action3 -= Show2;
        if (action3 != null)
        {
            action3();
        }

        // event�¼�
        // event�¼��Ƕ�ί�еķ�װ��ֻ�������ڲ����������������ⲿ������
        showDelegate = showgelegate;
        showDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Show1()
    {
        Debug.Log("Show1");
    }

    private void Show2()
    {
        Debug.Log("Show2");
    }

    private void showgelegate()
    {
        Debug.Log("showDelegate");
    }
}
