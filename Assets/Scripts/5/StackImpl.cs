using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackImpl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StackOperation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StackOperation()
    {
        MyStack stack = new();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        foreach(var i in stack)
        {
            Debug.LogFormat("{0}", i);
        }

        Debug.LogFormat("{0}", stack.Pop());
    }
}

public class MyStack : IEnumerable
{
    // 生成一个栈
    class StackData
    {
        public StackData nextItem;
        public object topData;
        public StackData(StackData next, object data)
        {
            this.nextItem = next;
            this.topData = data;
        }
    }

    StackData top;
    public void Push(object data)
    {
        top = new StackData(top, data);
    }
    public object Pop()
    {
        if (top == null)
        {
            return null;
        }
        else
        {
            object output = top.topData;
            top = top.nextItem;
            return output;
        }
    }

    public IEnumerator GetEnumerator()
    {
        StackData current = top;
        while (current != null)
        {
            yield return current.topData;
            current = current.nextItem;
        }
    }
}
