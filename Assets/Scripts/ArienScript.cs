﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArienScript : MonoBehaviour {
	GameObject arien;
	GameObject bang;
	public AudioSource doSound;
	public AudioSource hyuoSound;
	public GameObject camera;
	float avoid = 3.0f;
	bool lefty = false;
	bool righty = false;
	bool defo = true;
	public static float  speed = 1;



	// Use this for initialization
	void Start () {
		speed = VolcanoScript.tame * 0.5f;

	}

	// Update is called once per frame
	void Update () {
		
		if(righty){
			right();
		}
		if(lefty){
			left();
		}
		if (defo) {
			def();
		}
	}

	public void rPushDown(){
		righty = true;
		defo = false;
	}

	public void rPushUp(){
		righty = false;
		defo = true;

	}

	public void lPushDown(){
		lefty = true;
		defo = false;
	}

	public void lPushUp(){
		lefty = false;
		defo = true;
	}



	public void left(){
		if (transform.position.x >= -2.5) {
			transform.position += new Vector3 (-avoid * Time.deltaTime, 0, 0);
			transform.rotation = Quaternion.Euler (0, 20, 10);
		}
	}

	public void right(){
		if (transform.position.x <= 2.5) {
			transform.position += new Vector3 (avoid * Time.deltaTime, 0, 0);
			transform.rotation = Quaternion.Euler (0, -20, -10);
		}
	}

	public void def(){
		transform.rotation = Quaternion.Euler (0, 0, 0);
	}

	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Enemy") {
			if (speed > 3) {
				speed = speed - 3;
			}
			doSound.Play ();
			Destroy (other.gameObject);
			camera.SendMessage ("Vibe");
			camera.SendMessage ("ShakeObject");
		} else if (other.tag == "Kiryu") {
			speed = speed + 3;
			hyuoSound.Play ();
			Destroy (other.gameObject);
		}
	}
		
}

