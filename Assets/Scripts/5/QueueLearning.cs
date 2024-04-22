using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QueueOpera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void QueueOpera()
    {
        Queue<int> queue = new();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Debug.LogFormat("{0}", queue.Dequeue());

        foreach (var item in queue)
        {
            Debug.LogFormat("{0}", item);
        }
    }
}
