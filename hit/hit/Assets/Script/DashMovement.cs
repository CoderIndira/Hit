using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float DashTime;
    private int Direction;
    public float DashSpeed;
    public float StartDashTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DashTime = StartDashTime;
    }


    void Update()
    {
        if (Direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Direction = 2;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Direction = 3;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Direction = 4;
            }
            else
            {
                if (DashTime <= 0)
                {
                    Direction = 0;
                    DashTime = StartDashTime;
                    rb.velocity = Vector2.zero;
                }
                else
                {
                    DashTime -= Time.deltaTime;
                     if (Direction == 1)
                     {
                         rb.velocity = Vector2.left * DashSpeed;
                     }
                     else if (Direction == 2)
                     {
                         rb.velocity = Vector2.right * DashSpeed;
                     }
                     else if (Direction == 3)
                     {
                              rb.velocity = Vector2.up * DashSpeed;
                     }
                     else if (Direction == 2)
                     {
                              rb.velocity = Vector2.down * DashSpeed;
                     }

                }

            }
        }
    }
}
