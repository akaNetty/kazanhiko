﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversScript : MonoBehaviour {
	public float speed = 1;
	public GameObject time;
	public GameObject EnemyGenerator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		speed = ArienScript.speed;
		if (transform.position.y <= -1.8) {
			speed = 0;
			time.SendMessage ("Stop");
		}
		if (transform.position.y <= -0.8) {
			EnemyGenerator.SendMessage("Finish");
		}

		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}
