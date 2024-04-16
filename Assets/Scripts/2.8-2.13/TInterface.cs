using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 接口
// 接口是一种规范，是一种约定
// 接口不可被实例化
// 接口中的方法不能有方法体
// 接口中的方法不能有访问修饰符，默认为public
// 接口可以被继承

public class TInterface : MonoBehaviour
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

interface BaseInterface
{
    void ShowWindow();
    void HideWindow();
}

interface BaseInterface2 //: BaseInterface
{
    void PlaySound();
    void CloseSound();
}

interface BaseInterface3 : BaseInterface, BaseInterface2 // 接口可以被继承，可以单一继承，也可以多重继承
{
    new void ShowWindow();
    new void HideWindow();
    new void PlaySound();
    new void CloseSound();
}