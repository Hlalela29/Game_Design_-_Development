using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	public string loadLevel;

	public void playGame()
	{
		SceneManager.LoadScene (loadLevel);
	}
	public void quitGame()
	{
		Application.Quit();
	}

}
