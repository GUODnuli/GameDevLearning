using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// 1.�����ʼ���ļ��ַ�ʽ
// 2.�������� �޸�����
// 3.��λ�ȡ�����length
// 4.ʾ����ά����
// 5.��������

public class ArrayDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �����������û�з����ڴ�
        int[] array;
        int[] second_array = new int[5];

        // ��һ�ֳ�ʼ��
        int[] third_array = new int[] { 1, 2, 3, 4, 5 };  // ������ʽ����
        int[] fourth_array = new int[5] {1, 2, 3, 4, 5 }; // ������ʽ����

        Debug.LogFormat("third array's third element is {0}", third_array[2]);

        // �ڶ��ֳ�ʼ��
        int[] fifth_array = { 1, 2, 3, 4, 5 };

        Debug.LogFormat("fifth array's length is {0}", fifth_array.Length);
        fifth_array.Prepend(0);

        // ------------------------------------------------------------------------------------------//

        // ��ά����Demo
        int[,] sixth_array = new int[2, 2]; // 2��2�еĶ�ά����
        sixth_array[0, 0] = 1;
        sixth_array[0, 1] = 2;
        sixth_array[1, 0] = 3;
        sixth_array[1, 1] = 4;

        Debug.LogFormat("The four data of sixth array: {0}, {1}, {2}, {3}", sixth_array[0, 0], sixth_array[0, 1], sixth_array[1, 0], sixth_array[1, 1]);

        int[,] seventh_array = new int[,] { { 1, 2 }, { 3, 4 } };

        Debug.LogFormat("seventh array's length is {0}", seventh_array.Length);
        Debug.LogFormat("seventh array's row length is {0}", seventh_array.GetLength(0));
        Debug.LogFormat("seventh array's column length is {0}", seventh_array.GetLength(1));

        // ------------------------------------------------------------------------------------------//

        // nά����
        int[,,] eighth_array = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; // 2��2��2�����ά����

        // ��ӡeight_array������
        for (int i = 0; i < eighth_array.GetLength(0); i++)
        {
            for (int j = 0; j < eighth_array.GetLength(1); j++)
            {
                for (int k = 0; k < eighth_array.GetLength(2); k++)
                {
                    Debug.LogFormat("The data of eighth array is {0}", eighth_array[i, j, k]);
                }
            }
        }

        Debug.LogFormat("The eight array's length is {0}", eighth_array.Length);
        Debug.LogFormat("The eight array's row length is {0}", eighth_array.GetLength(0));
        Debug.LogFormat("The eight array's column length is {0}", eighth_array.GetLength(1));
        Debug.LogFormat("The eight array's layer length is {0}", eighth_array.GetLength(2));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
