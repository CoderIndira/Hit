using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingShow : MonoBehaviour
{
    public GameObject ring;
    bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        StartCoroutine(Visible(ring, 5f)); // 5 second

    }


    IEnumerator Visible(GameObject ring, float delay)
    {

        Renderer rend = gameObject.GetComponent<Renderer>();
        // GameObject rend = gameObject.GetComponent<GameObject>();

        if (rend.enabled) // isActive flase
        {
            yield return new WaitForSeconds(delay);
            rend.enabled = false;
            isActive = false;
            //  Destroy (gameObject);
            Debug.Log("false");
        }
        else
        {
            yield return new WaitForSeconds(delay);
            rend.enabled = true;
            isActive = true;
            // Instantiate(ring);
            Debug.Log("True");
        }


    }

 /*   void OnTriggerEnter2D(Collider2D other)
    {
        if(isActive == false)
        {
            other.
        }
    }*/


}
