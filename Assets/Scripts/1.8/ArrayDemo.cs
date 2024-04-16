using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// 1.数组初始化的几种方式
// 2.访问数据 修改数据
// 3.如何获取数组的length
// 4.示范二维数组
// 5.遍历数组

public class ArrayDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 数组的声明，没有分配内存
        int[] array;
        int[] second_array = new int[5];

        // 第一种初始化
        int[] third_array = new int[] { 1, 2, 3, 4, 5 };  // 容量隐式声明
        int[] fourth_array = new int[5] {1, 2, 3, 4, 5 }; // 容量显式声明

        Debug.LogFormat("third array's third element is {0}", third_array[2]);

        // 第二种初始化
        int[] fifth_array = { 1, 2, 3, 4, 5 };

        Debug.LogFormat("fifth array's length is {0}", fifth_array.Length);
        fifth_array.Prepend(0);

        // ------------------------------------------------------------------------------------------//

        // 二维数组Demo
        int[,] sixth_array = new int[2, 2]; // 2行2列的二维数组
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

        // n维数组
        int[,,] eighth_array = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } }; // 2行2列2层的三维数组

        // 打印eight_array的数据
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
