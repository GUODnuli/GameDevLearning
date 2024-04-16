using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 装箱和拆箱
// 装箱：将值类型转换为引用类型
// 拆箱：将引用类型转换为值类型
// 装箱和拆箱会影响性能，所以在实际开发中要尽量避免装箱和拆箱
// 装箱和拆箱是发生在值类型和引用类型之间的转换

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 20;
        object obj = a; // 装箱，将值类型转换为引用类型，装箱后obj中存储的是a的值，而不是a的地址
        int b = (int)obj; // 拆箱
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
