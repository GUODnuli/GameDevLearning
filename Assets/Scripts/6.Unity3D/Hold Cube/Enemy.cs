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
        Vector3 offset = speed * Time.fixedDeltaTime * transform.forward;
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
            // UIManager.Instance.UpdateScoreText();
            // DestroyImmediate(gameObject);
        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Player.Instance.Win();
        }
    }
}
