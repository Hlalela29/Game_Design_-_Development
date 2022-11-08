using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public string levelToLoad;
	public float waitTime= 4f;

	public static int SceneNumber;

	void Start () 
	{
		if (SceneNumber == 0)
		{
			StartCoroutine (ToSplashTwo ());

		}
		if (SceneNumber == 1)
		{
			StartCoroutine (ToMenu ());

		}

	}


	IEnumerator ToSplashTwo()
	{
		yield return new WaitForSeconds (waitTime);
		SceneNumber = 1;
		SceneManager.LoadScene (1);
	}

	IEnumerator ToMenu()
	{
		yield return new WaitForSeconds (waitTime);
		SceneNumber = 1;
		SceneManager.LoadScene (2);
	}
}