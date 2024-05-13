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
        // 按下时
        if (Input.GetMouseButtonDown(0))
        {
            print("按下了左键");
        }

        // 按下中
        if (Input.GetMouseButtonUp(0))
        {
            print("抬起了左键");
        }

        // 松开时
        if (Input.GetMouseButton(0))
        {
            Debug.LogFormat("按住了左键。");
            print(Input.mousePosition);
        }
    }
}
