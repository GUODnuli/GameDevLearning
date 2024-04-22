using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LinkedListOperation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LinkedListOperation()
    {
        LinkedList<int> linkedlist = new();
        LinkedListNode<int> node = linkedlist.AddFirst(1);
        linkedlist.AddAfter(node, 2);
        linkedlist.AddBefore(node, 0);

        Debug.LogFormat("linkedlist count: {0}", linkedlist.Count);
        foreach(int i in linkedlist)
        {
            Debug.LogFormat("{0}", i);
        }
        node = node.Next;
    }
}
