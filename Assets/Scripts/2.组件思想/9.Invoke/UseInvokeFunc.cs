using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseInvokeFunc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Demo", 3);
        InvokeRepeating("Demo", 1, 1);
        Invoke("CancelInvoke", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Demo()
    {
        Debug.Log("Demo");
    }
}
