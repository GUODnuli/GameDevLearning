using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int shoot_damage_point = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitinfo, 1000))
            {
                Debug.DrawLine(ray.origin, hitinfo.point, Color.red);
                if (hitinfo.collider.gameObject.tag == "Enemy")
                {
                    Enemy enemy = hitinfo.collider.gameObject.GetComponent<Enemy>();
                    enemy.Hurt(shoot_damage_point);
                }
            }
        }
    }
}
