using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TimeScript : MonoBehaviour {
	public AudioSource okSound;
	public Text timeLabel;
	public Text goaltime;
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

	private string iti1 = "STAGE11";
	private string ni1 = "STAGE12";
	private string san1 = "STAGE13";
	private string yon1 = "STAGE14";
	private string gou1 = "STAGE15";
	private string iti2 = "STAGE21";
	private string ni2 = "STAGE22";
	private string san2 = "STAGE23";
	private string yon2 = "STAGE24";
	private string gou2 = "STAGE25";
	private string iti3 = "STAGE31";
	private string ni3 = "STAGE32";
	private string san3 = "STAGE33";
	private string yon3 = "STAGE34";
	private string gou3 = "STAGE35";


	public int stage;
	public int rank;
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
		rank = title.rank;
		startTime = DateTime.Now;
		goaltime.text =  "";
	}
	
	// Update is called once per frame
	void Update () {

		itis1 = PlayerPrefs.GetFloat (iti1, 99999);
		nis1 = PlayerPrefs.GetFloat (ni1, 99999);
		sans1 = PlayerPrefs.GetFloat (san1, 99999);
		yons1 = PlayerPrefs.GetFloat (yon1, 99999);
		gous1 = PlayerPrefs.GetFloat (gou1, 99999);
		itis2 = PlayerPrefs.GetFloat (iti2, 99999);
		nis2 = PlayerPrefs.GetFloat (ni2, 99999);
		sans2 = PlayerPrefs.GetFloat (san2, 99999);
		yons2 = PlayerPrefs.GetFloat (yon2, 99999);
		gous2 = PlayerPrefs.GetFloat (gou2, 99999);
		itis3 = PlayerPrefs.GetFloat (iti3, 99999);
		nis3 = PlayerPrefs.GetFloat (ni3, 99999);
		sans3 = PlayerPrefs.GetFloat (san3, 99999);
		yons3 = PlayerPrefs.GetFloat (yon3, 99999);
		gous3 = PlayerPrefs.GetFloat (gou3, 99999);



		if (ufo == false) {
			timer += Time.deltaTime;

			timeLabel.text =  "Time:"  +timer.ToString ("f1");

//
//			if (flag == 1) {
//				DateTime startTime = DateTime.Now;
//				flag = 2;
//
//
//			}
		}

	}

	void Stop(){
		ufo = true;
		Goal.SetActive (true);
		Retry.SetActive (true);

		goaltime.text =  "Time:"  +timer.ToString ("f1");

		DateTime now = DateTime.Now;
		TimeSpan deltaTime = now - startTime;

//		var timeScore = deltaTime;

		if (rank == 2) {
			
			naichilab.RankingLoader.Instance.SendScoreAndShowRanking (deltaTime);
		}

		if (rank == 1) {

			if (stage == 1) {
				if (timer <= gous1) {
					gous1 = timer;
					PlayerPrefs.SetFloat (gou1, gous1);
					if (timer <= yons1) {
						yonq1 = yons1;
						gous1 = yonq1;
						PlayerPrefs.SetFloat (gou1, gous1);
						yons1 = timer; 
						PlayerPrefs.SetFloat (yon1, yons1);
						if (timer <= sans1) {
							sanq1 = sans1;
							yons1 = sanq1;
							PlayerPrefs.SetFloat (yon1, yons1);
							sans1 = timer;
							PlayerPrefs.SetFloat (san1, sans1);
							if (timer <= nis1) {
								niq1 = nis1;
								sans1 = niq1;
								PlayerPrefs.SetFloat (san1, sans1);
								nis1 = timer;
								PlayerPrefs.SetFloat (ni1, nis1);
								if (timer <= itis1) {
									itiq1 = itis1;
									nis1 = itiq1;
									PlayerPrefs.SetFloat (ni1, nis1);
									itis1 = timer;
									PlayerPrefs.SetFloat (iti1, itis1);
								}
							}
						}
					}
				}
			}


			if (stage == 2) {
				if (timer <= gous2) {
					gous2 = timer;
					PlayerPrefs.SetFloat (gou2, gous2);
					if (timer <= yons2) {
						yonq2 = yons2;
						gous2 = yonq2;
						PlayerPrefs.SetFloat (gou2, gous2);
						yons2 = timer; 
						PlayerPrefs.SetFloat (yon2, yons2);
						if (timer <= sans2) {
							sanq2 = sans2;
							yons2 = sanq2;
							PlayerPrefs.SetFloat (yon2, yons2);
							sans2 = timer;
							PlayerPrefs.SetFloat (san2, sans2);
							if (timer <= nis2) {
								niq2 = nis2;
								sans2 = niq2;
								PlayerPrefs.SetFloat (san2, sans2);
								nis2 = timer;
								PlayerPrefs.SetFloat (ni2, nis2);
								if (timer <= itis2) {
									itiq2 = itis2;
									nis2 = itiq2;
									PlayerPrefs.SetFloat (ni2, nis2);
									itis2 = timer;
									PlayerPrefs.SetFloat (iti2, itis2);
								}
							}
						}
					}
				}
			}
		


			if (stage == 3) {
				if (timer <= gous3) {
					gous3 = timer;
					PlayerPrefs.SetFloat (gou3, gous3);
					if (timer <= yons3) {
						yonq3 = yons3;
						gous3 = yonq3;
						PlayerPrefs.SetFloat (gou3, gous3);
						yons3 = timer; 
						PlayerPrefs.SetFloat (yon3, yons3);
						if (timer <= sans3) {
							sanq3 = sans3;
							yons3 = sanq3;
							PlayerPrefs.SetFloat (yon3, yons3);
							sans3 = timer;
							PlayerPrefs.SetFloat (san3, sans3);
							if (timer <= nis3) {
								niq3 = nis3;
								sans3 = niq3;
								PlayerPrefs.SetFloat (san3, sans3);
								nis3 = timer;
								PlayerPrefs.SetFloat (ni3, nis3);
								if (timer <= itis3) {
									itiq3 = itis3;
									nis3 = itiq3;
									PlayerPrefs.SetFloat (ni3, nis3);
									itis3 = timer;
									PlayerPrefs.SetFloat (iti3, itis3);
								}
							}
						}
					}
				}
			}
		}
			


	}

	public void retry(){
		okSound.Play ();
		SceneManager.LoadScene ("Title");
	}
}
