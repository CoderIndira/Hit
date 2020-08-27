using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;
    public bool isRed;
    public float distance = 0.3f;
    public Rigidbody2D rb;
    public float Speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(isRed == false)
        {
            destination = GameObject.FindGameObjectWithTag("RedPortal").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("GreenPortal").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
            //rb.AddForce (transform.);
            Debug.Log("Force");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
