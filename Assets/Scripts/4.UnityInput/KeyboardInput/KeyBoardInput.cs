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
        // 按下时
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("蓄力中......");
        }

        // 按下中
        if (Input.GetKey(KeyCode.W))
        {
            print(attackValue);
            attackValue++;
        }

        // 松开时
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.LogFormat("攻击！造成伤害{0}!", attackValue);
            attackValue = 0;
        }
    }
}
