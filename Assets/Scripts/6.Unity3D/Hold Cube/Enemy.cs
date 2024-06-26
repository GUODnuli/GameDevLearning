using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    private readonly float speed = 2f;
    private int health_point = 100;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 offset = transform.forward * Time.fixedDeltaTime * speed;
        rb.MovePosition(transform.position + offset);
    }

    public void Hurt(int damage)
    {
        health_point -= damage;
        Dead();
    }

    private void Dead()
    {
        if (health_point <= 0)
        {
            DestroyImmediate(gameObject);
        }
        Debug.LogFormat("Number of enemies: {0}", GameObject.FindGameObjectsWithTag("Enemy").Length);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Player.Instance.Win();
        }
    }
}
