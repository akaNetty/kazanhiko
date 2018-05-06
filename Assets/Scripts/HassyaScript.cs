using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HassyaScript : MonoBehaviour {
	public GameObject arien;
	public GameObject voltage;
	public GameObject magma;
	public VolcanoScript script;


	// Use this for initialization
	void Start () {
		magma.SetActive (false);
		voltage = GameObject.Find("voltage");
		script = voltage.GetComponent<VolcanoScript> ();
	}

	// Update is called once per frame
	void Update () {
		float speed = VolcanoScript.tame * 0.5f;
		float timer = script.timer;
		if (timer >= 3.0f) {
			magma.SetActive (true);
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (transform.position.y >= 8) {
			SceneManager.LoadScene ("Main");
		}
	}
}
