using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BallBouncer : MonoBehaviour
{
	private Rigidbody2D rb;

	Vector3 lastVelocity;
	public ParticleSystem vfx;
	//public GameObject sfx;


	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		lastVelocity = rb.velocity;
	}

	private void OnCollisionEnter2D(Collision2D col)
    {
        Bounce(col);

     

        BounceSFX();
        vfx.transform.position = transform.position;
       StartCoroutine( BounceVFX());

       

    }

    private void Bounce(Collision2D col)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, col.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }

 

    private IEnumerator BounceVFX()
    {
        // Debug.Log("VFX");
     ParticleSystem bomb= Instantiate(vfx, transform.position, transform.rotation);
        bomb.Play();
        yield return new WaitForSeconds(1);
        bomb.Stop();
    }
 
	private void BounceSFX()
    {
		GetComponent<AudioSource>().Play();
    }

	

}
