using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {

	AudioSource foodSound;
	MeshRenderer meshrenderer;

	// Use this for initialization
	void Start () {
		foodSound = GetComponent <AudioSource>();
		meshrenderer = GetComponent <MeshRenderer>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {				// x 7
			ScoreManager.score += 30;
			foodSound.Play ();
			meshrenderer.enabled = false;
		}
	}
}
