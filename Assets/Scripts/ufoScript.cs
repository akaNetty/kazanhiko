﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position += new Vector3 (1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void away(){
		transform.position += Vector3.up * 7.0f * Time.deltaTime;
	}
}
