using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hole : MonoBehaviour
{
    [SerializeField] private ParticleSystem vfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            vfx.transform.position = transform.position;
            StartCoroutine(VortexVFX());
            VortexSFX();
            Destroy(collision.gameObject);


            StartCoroutine(LoadNext());
            

        }
    }
    private IEnumerator VortexVFX()
    {
        // Debug.Log("VFX");
        ParticleSystem bomb = Instantiate(vfx, transform.position, transform.rotation);
        bomb.Play();
        yield return new WaitForSeconds(1);
        bomb.Stop();
    }

    private IEnumerator LoadNext()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void VortexSFX()
    {
        GetComponent<AudioSource>().Play();
    }
}
