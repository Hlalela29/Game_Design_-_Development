using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playVideo : MonoBehaviour {

	public MovieTexture movieClip;

	// Use this for initialization
	void Start () {

		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();

		StartCoroutine(WaitForSeconds());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitForSeconds()
	{
		yield return new WaitForSeconds (29f);
		SceneManager.LoadScene("Menu");
	}
}
