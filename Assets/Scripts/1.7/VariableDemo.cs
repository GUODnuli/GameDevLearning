using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string strMonsterName = "Goblin";
        int iMonsterHealth = 100;
        int ilevel = 5;
        long lExperience = 1000;

        Debug.LogFormat("\nMonster Name: {0}\nHealth: {1}\nLevel: {2}\nExperience:{3}", strMonsterName, iMonsterHealth, ilevel, lExperience);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
