using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInput : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("������......");
        }

        // ������
        if (Input.GetKey(KeyCode.W))
        {
            print(attackValue);
            attackValue++;
        }

        // �ɿ�ʱ
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.LogFormat("����������˺�{0}!", attackValue);
            attackValue = 0;
        }
    }
}
