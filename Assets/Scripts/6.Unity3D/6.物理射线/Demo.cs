using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(Vector3.zero, new Vector3(0, 1, 0));

        if (Physics.Raycast(ray, out RaycastHit hitinfo, 1000))
        {
            Debug.Log("����������ĳ������");
            Debug.Log(string.Format("����������{0}, ��λ��{1}", hitinfo.collider.gameObject.name, hitinfo.point));
        }
    }
}
