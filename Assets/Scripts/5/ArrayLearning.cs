using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateArray()
    {
        int[] array1;
        int[] array2 = new int[5] {1, 2, 3, 4, 5};
        int[] array3 = {1, 2, 3, 4, 5};
        array1 = new int[5];
    }
}
