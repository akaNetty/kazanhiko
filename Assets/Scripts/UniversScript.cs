﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversScript : MonoBehaviour {
	public float speed = 1;
	public GameObject time;
	public GameObject EnemyGenerator;
	public Slider height;
	public float kyori = 120;
	public float takasa = 0;
	public int stage;

	// Use this for initialization
	void Start () {
		height = GameObject.Find("Height").GetComponent<Slider>();
		stage = title.stage;
	}
	
	// Update is called once per frame
	void Update () {
		if (stage == 2) {
			kyori = 91;
		}
		height.maxValue = kyori;
		Debug.Log (kyori);
		takasa = 120 - transform.position.y + 1.8f;
		height.value = takasa;
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
