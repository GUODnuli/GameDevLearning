using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueImpl : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        QueueOperation();
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void QueueOperation()
    {
        MyQueue queue = new();
        queue.Push(1);
        queue.Push(2);
        queue.Push(3);

        foreach(var i in queue)
        {
            Debug.LogFormat("{0}", i);
        }

        Debug.LogFormat("PopData: {0}", queue.Pop());
        
    }
}

public class MyQueue : IEnumerable
{
    // 生成一个栈
    public class QueueData
    {
        public QueueData nextItem;
        public object topData;
        public QueueData(QueueData next, object data)
        {
            this.nextItem = next;
            this.topData = data;
        }
    }

    public QueueData first;
    public QueueData last;
    public void Push(object data)
    {
        QueueData newItem = new(null, data);
        if (first == null)
        {
            first = newItem;
        }
        else if (first.nextItem == null)
        {
            last = newItem;
            first.nextItem = last;
        }
        else
        {
            last.nextItem = newItem;
            last = last.nextItem;
        }
    }
    public object Pop()
    {
        if (first == null)
        {
            Debug.Log("Pop called but the queue is empty");
            return null;
        }
        else
        {
            object output = first.topData;
            first = first.nextItem;
            Debug.Log("Pop called, returning: " + output);
            return output;
        }
    }

    public IEnumerator GetEnumerator()
    {
        QueueData current = first;
        while (current != null)
        {
            yield return current.topData;
            current = current.nextItem;
        }
    }
}