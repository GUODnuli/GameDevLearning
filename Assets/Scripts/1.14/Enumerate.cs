using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Enum <--> int
// Enum <--> string

public class Enumerate : MonoBehaviour
{
    public enum emAction
    {
        None,
        Attack,
        Skill,
        Item,
        Defend,
        Run
    }

    public emAction mAction = emAction.None;

    // Start is called before the first frame update
    void Start()
    {
        Demo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Demo()
    {
        Debug.LogFormat("maction: {0}", mAction);
        Debug.LogFormat("maction: {0}", mAction.ToString());
        
        Enum.Parse(typeof(emAction), "Attack");
        mAction = (emAction)Enum.Parse(typeof(emAction), "Attack");
        Debug.LogFormat("maction: {0}", mAction);

        mAction = emAction.Defend;
        Debug.LogFormat("maction: {0}", (int)mAction);

        mAction = (emAction)1;
        Debug.LogFormat("maction: {0}", mAction);
    }
}
