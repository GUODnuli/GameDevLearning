using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineLearning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine2());
        StopAllCoroutines();
        StopCoroutine(MyCoroutine2());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetNumber()
    {
        return 0;
    }

    public IEnumerator MyCoroutine()
    {
        Debug.LogFormat("Start Coroutine");
        yield return new WaitForSeconds(5.0f);
        Debug.LogFormat("End Coroutine");
    }

    public IEnumerator MyCoroutine2()
    {
        while (true)
        {
            transform.Rotate(new Vector3(5, 0, 0));
            yield return new WaitForSeconds(0.1f);
        }
    }
}
