using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public int CountHit;
    public int Chance = 3;
    
    // Start is called before the first frame update
    void Start()
    {

        CountHit = 0;
        Chance = 3;
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Debug.Log("hit");
        }
        CountHit++;
        if (CountHit == 4)
        {
            Destroy(gameObject);
            Chance--;
            Debug.Log("destroyed");
        }
    }

  

}