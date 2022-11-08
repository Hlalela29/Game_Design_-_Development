using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playCollision : MonoBehaviour {

	public int score = 0;
	public Text DisplayScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DisplayScore.GetComponent<Text>().text = "Score: " + score.ToString ();
	}

	public void OnTriggerEnter(Collider col)
	{
		
		if(col.gameObject.name == "applez")
		{
			score = score +  1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (1)")
		{
			score = score + 1 ;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (2)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (3)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (4)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (5)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}

		if(col.gameObject.name == "applez (6)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (7)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (8)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (9)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (10)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (11)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "applez (12)")
		{
			score = score + 1;
			Destroy(col.gameObject);
		}


	}
}
