using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkController : MonoBehaviour {

	AudioSource drinkSound;
	MeshRenderer meshrenderer;

	// Use this for initialization
	void Start () {
		drinkSound = GetComponent <AudioSource>();
		meshrenderer = GetComponent <MeshRenderer>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {			// x 5
			drinkSound.Play ();
			ScoreManager.score += 100;
			meshrenderer.enabled = false;
		}
	}
}
