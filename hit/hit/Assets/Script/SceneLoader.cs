using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{ 

		Debug.Log("Quit");
		Application.Quit();
	}

	public void RestartGame()
    {
		Debug.Log("Restart");
		SceneManager.LoadScene(1);
	}

	public void MainMenu()
    {
		Debug.Log("Main Menu");
		SceneManager.LoadScene(0);
    }
}
