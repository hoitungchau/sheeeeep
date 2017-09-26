using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour {

	Animator anim;
	MeshRenderer meshrenderer;
	public GameObject BigSheep;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		meshrenderer = GetComponent <MeshRenderer>();
		BigSheep.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float x = h * Time.deltaTime * 1.5f;

		//transform.Rotate (0, x, 0, Space.World);
		//transform.Translate (0.1f, 0, x, Space.World);
		if (ScoreManager.score < 710) {
			transform.Translate (x, 0, 0.12f, Space.World);
			Camera.main.transform.Translate (0, 0, 0.12f, Space.World);
			anim.SetBool ("isWalking", true);
		}

		if (ScoreManager.score == 710) {
			gameObject.SetActive(false);
			BigSheep.SetActive (true);
			anim.SetBool ("isWalking", false);
		}

		//bool walking = h != 0f || v != 0f;
		//anim.SetBool ("isWalking", walking);



	}
}
