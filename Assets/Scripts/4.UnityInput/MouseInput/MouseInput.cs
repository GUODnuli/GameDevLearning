using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    int attackValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����ʱ
        if (Input.GetMouseButtonDown(0))
        {
            print("���������");
        }

        // ������
        if (Input.GetMouseButtonUp(0))
        {
            print("̧�������");
        }

        // �ɿ�ʱ
        if (Input.GetMouseButton(0))
        {
            Debug.LogFormat("��ס�������");
            print(Input.mousePosition);
        }
    }
}
