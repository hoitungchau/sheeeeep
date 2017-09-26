using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelebrationController : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreManager.score == 710) {
			anim.SetTrigger ("Celebration");
		}
	}
}
