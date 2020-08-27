using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortal : MonoBehaviour
{

    private Vector2 target;
    private Transform greenPortal;
    private Transform redPortal;
    // Start is called before the first frame update
    void Start()
    {
        greenPortal = GameObject.FindGameObjectWithTag("GreenPortal").GetComponent<Transform>();
        redPortal = GameObject.FindGameObjectWithTag("RedPortal").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            greenPortal.position = new Vector2(target.x, target.y);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            redPortal.position = new Vector2(target.x, target.y);
        }
            
    }
}
