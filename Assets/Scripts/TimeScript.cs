using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	public Text timeLabel;
	public Text goal;
	public GameObject Goal;
	public GameObject Retry;
	float timer = 0.0f;
	bool ufo = false;

	// Use this for initialization
	void Start () {
		Goal.SetActive (false);
		Retry.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (ufo == false) {
			timer += Time.deltaTime;
			timeLabel.text =  "Time : "  +timer.ToString ("f1");

		}
	}

	void Stop(){
		Debug.Log ("stop!");
		ufo = true;
		Goal.SetActive (true);
		Retry.SetActive (true);
		goal.text = "GOAL" + "\n" + "Time:" +timer.ToString ("f1");
	}

	public void retry(){
		SceneManager.LoadScene ("Title");
	}
}
