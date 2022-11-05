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
		if(col.gameObject.name == "TreasureBox")
		{
		  score = score + 5;
		  Destroy(col.gameObject);
		}
		if(col.gameObject.name == "TreasureBox (1)")
		{
			score = score + 5;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "TreasureBox (2)")
		{
			score = score + 5;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "TreasureBox (3)")
		{
			score = score + 5;
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "TreasureBox (4)")
		{
			score = score + 5;
			Destroy(col.gameObject);
		}

		if (score >= 25)
		{
			SceneManager.LoadScene("Congratulations");

		}

	}
}
