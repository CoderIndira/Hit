using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMove : MonoBehaviour
{
    public float speed = 5f;

    bool turn = true;

    private SpriteRenderer sr;

    public ParticleSystem vfx;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(turn)
        {
            moveright();
        }
        if(!turn)
        {
            moveleft();
        }
        if(transform.position.x >= 1.55f)
        {
            turn = false;
            sr.flipX = true;
        }
        if(transform.position.x <= -1.55f)
        {
            turn = true;
            sr.flipX = false;
        }
    }

    void moveright()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    void moveleft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ball"))
        {
            vfx.transform.position = transform.position;
            StartCoroutine(BounceVFX());
            //     Debug.Log("vfx");
            BreakSFX();
            Destroy(col.gameObject);
        }


    }

    private IEnumerator BounceVFX()
    {
        // Debug.Log("VFX");
        ParticleSystem bomb = Instantiate(vfx, transform.position, transform.rotation);
        bomb.Play();
        yield return new WaitForSeconds(1);
        bomb.Stop();
    }

    private void BreakSFX()
    {
        GetComponent<AudioSource>().Play();
    }
}
