using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	Rigidbody2D rb;
	bool hasHit = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if( hasHit == false)
		{
			TrackMovement();
        }
           
	}

	void TrackMovement()
	{
		Vector2 direction = rb.velocity;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		hasHit = true;
		rb.velocity = Vector2.zero;
		
	}
		
}
