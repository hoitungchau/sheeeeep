using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score;
	Text ScoreText;
	//Animator anim;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		ScoreText = GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score : " + score;
	}
}
