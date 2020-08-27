using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("ball"))
        {
            Debug.Log("Trigger");
            rb.velocity = new Vector2 ( transform.position.x, 0) * Speed;
        }

    }
}
