using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float timez = 100.0f;
	public Text timeDisplay;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update () {
		if (timez > 0)
		{
			timez -= Time.deltaTime;
			timeDisplay.GetComponent<Text> ().text = " " + timez.ToString ("0");
		}

		if (timez < 0) 
		{
			SceneManager.LoadScene("Level 2");

		}

	}
}







	

	


