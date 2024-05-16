using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Enter");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Exit");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print("Stay");
    }
}
