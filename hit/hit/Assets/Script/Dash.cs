using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : FastMove
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            rb.velocity = new Vector2(transform.position.x, 0) * Speed;
        }
    }
}
