using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TimeScript : MonoBehaviour {
	public Text timeLabel;
	public GameObject Goal;
	public GameObject Retry;
	public TimeSpan delta;
	public static float iti = 99999;
	public static float ni = 99999;
	public static float san = 99999;
	public static float yon = 99999;
	public static float gou = 99999;
	public float itiq = 0;
	public float niq = 0;
	public float sanq = 0;
	public float yonq = 0;
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
//		DateTime now = DateTime.Now;
//		TimeSpan deltaTime = now - startTime;
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


		DateTime now = DateTime.Now;
		TimeSpan deltaTime = now - startTime;

//		var millsec = 123456;
//		var timeScore = new System.TimeSpan (0, 0, 0, 0, millsec);


		var timeScore = deltaTime;
//		return delta.ToString ("HH:ss");


//		naichilab.RankingLoader.Instance.SendScoreAndShowRanking (timeScore);

		if (timer <= gou) {
			gou = timer;
			if (timer <= yon) {
				yonq = yon;
				gou = yonq;
				yon = timer; 
				if (timer <= san) {
					sanq = san;
					yon = sanq;
					san = timer;
					if (timer <= ni) {
						niq = ni;
						san = niq;
						ni = timer;
						if (timer <= iti) {
							itiq = iti;
							ni = itiq;
							iti = timer;
						}
					}
				}
			}
		}

	}

	public void retry(){
		SceneManager.LoadScene ("Title");
	}
}
