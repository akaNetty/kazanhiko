using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HassyaScript : MonoBehaviour {
	public GameObject arien;
	public GameObject voltage;
	public VolcanoScript script;


	// Use this for initialization
	void Start () {
		voltage = GameObject.Find("voltage");
		script = voltage.GetComponent<VolcanoScript> ();
	}

	// Update is called once per frame
	void Update () {
		int speed = VolcanoScript.tame;
		float timer = script.timer;
		if (timer >= 3.0f) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (transform.position.y >= 8) {
			SceneManager.LoadScene ("Main");
		}
	}
}
