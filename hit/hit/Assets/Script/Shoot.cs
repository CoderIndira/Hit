using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shoot : MonoBehaviour
{
	public float LaunchForce;
    public GameObject Arrow;
	[SerializeField]  
	private ParticleSystem vfx;
	//public GameObject Explosion;
	public int chance = 0;
	public bool isActive = false;
	


	void Start()
	{
		
		Debug.Log("false");
		isActive = true;
		Debug.Log("true");
	}

/*	void OnEnable()
    {
		isActive = true;
		Debug.Log("OnEnable true");
    }*/

	void Update()
	{
		
		if (Input.GetMouseButtonDown(0) && chance < 3 && isActive == true)
		{
			Debug.Log("true");
			chance ++;
			ShootArrow();
			vfx.transform.position = transform.position;
			StartCoroutine(ShootVFX());
			
			
			ShootSFX();

			if(chance == 3)
            {
				StartCoroutine(LoadGameOver());
			}
			
			isActive = false;
			Debug.Log("false");

		}

		else if(isActive == false)
		{
			isActive = true;
        }


		IEnumerator LoadGameOver()
        {
			yield return new WaitForSeconds(2);
			SceneManager.LoadScene(6);
		}
			
		
	

	}

	void ShootArrow()
	{
		GameObject ArrowIns = Instantiate(Arrow, transform.position, transform.rotation);
		ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);

		
	}

	private void ShootSFX()
	{

		GetComponent<AudioSource>().Play();

	}

	private IEnumerator ShootVFX()
	{
		// Debug.Log("VFX");
		ParticleSystem shoot = Instantiate(vfx, transform.position, transform.rotation);
		shoot.Play();
		yield return new WaitForSeconds(1);
		shoot.Stop();
	}


}