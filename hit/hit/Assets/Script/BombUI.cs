using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BombUI : MonoBehaviour
{
    public static float numberOFShots;
  //  public Transform ShotTxt;
    public Transform B1;
    public Transform B2;
    public Transform B3;
	public static bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
		numberOFShots = 3;
		isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log("Game Strt");
		if (isActive == true)
		{
			if (numberOFShots > 0)
			{
				B1.GetComponent<Image>().enabled = true;
			}

			else
			{
				B1.GetComponent<Image>().enabled = false;
			}

			if (numberOFShots > 1)
			{
				
				B2.GetComponent<Image>().enabled = true;
			}

			else
			{
				B2.GetComponent<Image>().enabled = false;
			}

			if (numberOFShots > 2)
			{
				B3.GetComponent<Image>().enabled = true;
			}

			else
			{
				B3.GetComponent<Image>().enabled = false;
			}




			if (Input.GetMouseButtonDown(0))
			{
				numberOFShots -= 1;
				//	ShotTxt.GetComponent<Text>().text = numberOFShots.ToString();
			}
		}
		else if(isActive == false)
        {
			
			Debug.Log("Game Over");
        }
	}
}
