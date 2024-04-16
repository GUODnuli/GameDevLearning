using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDelegate : MonoBehaviour
{
    public delegate void ShowDelegate();
    public delegate void ShowDelegate2(int a, int b);
    public delegate int ShowDelegate3(int a);
    public delegate void ShowDelegate4<T>(T a);

    // Start is called before the first frame update
    void Start()
    {
        ShowDelegate show = ShowFn;
        show();
        show.Invoke();

        ShowDelegate2 show2 = ShowFn2;
        show2(1, 2);
        show2.Invoke(3, 4);

        ShowDelegate3 show3 = ShowFn3;
        Debug.Log(show3(5));

        ShowDelegate4<string> show4 = ShowFn4;
        show4("Hello");
        show4.Invoke("World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowFn()
    {
        Debug.Log("ShowFn");
    }

    public void ShowFn2(int a, int b)
    {
        Debug.Log("ShowFn2");
        Debug.LogFormat("a:{0}, b:{1}", a, b);
    }

    public int ShowFn3(int a)
    {
        Debug.Log("ShowFn3");
        return a;
    }

    public void ShowFn4<T>(T a)
    {
        Debug.Log("ShowFn4");
        Debug.Log(a);
    }
}
