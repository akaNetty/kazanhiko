using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TimeScript : MonoBehaviour {
	public Text timeLabel;
	public Text goal;
	public GameObject Goal;
	public GameObject Retry;
	float timer = 0.0f;
	bool ufo = false;
	int flag = 1;
	DateTime startTime;
	DateTime now;

	// Use this for initialization
	void Start () {
		Goal.SetActive (false);
		Retry.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		DateTime now = DateTime.Now;
		TimeSpan deltaTime = now - startTime;
		if (ufo == false) {
			timer += Time.deltaTime;
			timeLabel.text =  "Time : "  +timer.ToString ("f1");


			if (flag == 1) {
				DateTime startTime = DateTime.Now;
				flag = 2;


			}
		}
	}

	void Stop(){
		ufo = true;
		Goal.SetActive (true);
		Retry.SetActive (true);
		goal.text = "GOAL" + "\n" + "Time:" +timer.ToString ("f1");


		DateTime now = DateTime.Now;
		TimeSpan deltaTime = now - startTime;

//		var millsec = 123456;
//		var timeScore = new System.TimeSpan (0, 0, 0, 0, millsec);
		var timeScore = deltaTime;
		naichilab.RankingLoader.Instance.SendScoreAndShowRanking (timeScore);


	}

	public void retry(){
		SceneManager.LoadScene ("Title");
	}
}
