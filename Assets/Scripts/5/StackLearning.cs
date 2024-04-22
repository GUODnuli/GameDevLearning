using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackLearning : MonoBehaviour
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
        Stack st = new();
        st.Push(1);
        st.Push(2);
        st.Push(3);

        foreach (var item in st)
        {
            Debug.LogFormat("{0}", item);
        }

        Debug.LogFormat("Pop: {0}", st.Pop());
    }
}
