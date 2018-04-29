using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public Text timeLabel;
	float timer = 0.0f;
	bool ufo = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ufo == false) {
			timer += Time.deltaTime;
			timeLabel.text =  "Time : " +timer.ToString ("f1");

		}
	}

	void Stop(){
		ufo = true;
	}
}
