using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateArrayList()
    {
        ArrayList arrayList1 = new();
        int[] array1 = {1, 2, 3, 4};

        arrayList1.Add(1);
        arrayList1.Add(2);
        arrayList1.Add(3);
        Debug.Log(arrayList1[0]);
        arrayList1.AddRange(array1);

        uint index = 0;
        foreach(int i in arrayList1)
        {
            Debug.LogFormat("arrayList1[{0}]: {1}", index, i);
            index++;
        }
    }
}
