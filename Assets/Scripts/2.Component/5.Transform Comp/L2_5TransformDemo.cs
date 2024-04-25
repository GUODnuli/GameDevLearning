using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_5TransformDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("{0}", transform.childCount);
        Debug.LogFormat("{0}", transform.parent);
        Debug.LogFormat("{0}", transform.root);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.LogFormat("Transform.position: {0}", transform.position);
        // Debug.LogFormat("Transform.localPosition: {0}", transform.localPosition);
        // Debug.LogFormat("Transform.rotation: {0}", transform.rotation);
    }
}
