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
	public static float itis1 = 99999;
	public static float nis1 = 99999;
	public static float sans1 = 99999;
	public static float yons1 = 99999;
	public static float gous1 = 99999;
	public static float itis2 = 99999;
	public static float nis2 = 99999;
	public static float sans2 = 99999;
	public static float yons2 = 99999;
	public static float gous2 = 99999;
	public static float itis3 = 99999;
	public static float nis3 = 99999;
	public static float sans3 = 99999;
	public static float yons3 = 99999;
	public static float gous3 = 99999;
	public float itiq1 = 0;
	public float niq1 = 0;
	public float sanq1 = 0;
	public float yonq1 = 0;
	public float itiq2 = 0;
	public float niq2 = 0;
	public float sanq2 = 0;
	public float yonq2 = 0;
	public float itiq3 = 0;
	public float niq3 = 0;
	public float sanq3 = 0;
	public float yonq3 = 0;
	public int stage;
	float timer = 0.0f;
	bool ufo = false;
	int flag = 1;



	DateTime startTime;
	DateTime now;

	// Use this for initialization
	void Start () {
		Goal.SetActive (false);
		Retry.SetActive (false);
		stage = title.stage;

	}
	
	// Update is called once per frame
	void Update () {




		if (ufo == false) {
			timer += Time.deltaTime;

			timeLabel.text =  "Time:"  +timer.ToString ("f1");


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


		if(stage == 1){
			if (timer <= gous1) {
				gous1 = timer;

				if (timer <= yons1) {
					yonq1 = yons1;
					gous1 = yonq1;

					yons1 = timer; 

					if (timer <= sans1) {
						sanq1 = sans1;
						yons1 = sanq1;

						sans1 = timer;

						if (timer <= nis1) {
							niq1 = nis1;
							sans1 = niq1;

							nis1 = timer;

							if (timer <= itis1) {
								itiq1 = itis1;
								nis1 = itiq1;

								itis1 = timer;

							}
						}
					}
				}
			}
		}


		if(stage == 2){
			if (timer <= gous2) {
				gous2 = timer;

				if (timer <= yons2) {
					yonq2 = yons2;
					gous2 = yonq2;

					yons2 = timer; 

					if (timer <= sans2) {
						sanq2 = sans2;
						yons2 = sanq2;

						sans2 = timer;

						if (timer <= nis2) {
							niq2 = nis2;
							sans2 = niq2;

							nis2 = timer;

							if (timer <= itis2) {
								itiq2 = itis2;
								nis2 = itiq2;

								itis2 = timer;

							}
						}
					}
				}
			}
		}


		if(stage == 3){
			if (timer <= gous3) {
				gous3 = timer;

				if (timer <= yons3) {
					yonq3 = yons3;
					gous3 = yonq3;

					yons3 = timer; 

					if (timer <= sans3) {
						sanq3 = sans3;
						yons3 = sanq3;

						sans3 = timer;

						if (timer <= nis3) {
							niq3 = nis3;
							sans3 = niq3;

							nis3 = timer;

							if (timer <= itis3) {
								itiq3 = itis3;
								nis3 = itiq3;

								itis3 = timer;

							}
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
