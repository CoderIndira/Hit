using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public float Speed = 5f;
    bool turn = true;

   
    // Start is called before the first frame update
    void Start()
    {
       // sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (turn)
        {
            moveup();
        }
        if (!turn)
        {
            movedown();
        }
        if (transform.position.y >= 1.70f)
        {
            turn = false;
          
        }
        if (transform.position.y <= -2.6f)
        {
            turn = true;
          
        }
    }

    void moveup()
    {
        transform.Translate(0, Speed * Time.deltaTime, 0);
    }

    void movedown()
    {
        transform.Translate(0, -Speed * Time.deltaTime, 0);
    }
}

