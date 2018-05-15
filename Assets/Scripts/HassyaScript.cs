using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HassyaScript : MonoBehaviour {
	public GameObject arien;
	public GameObject voltage;
	public GameObject magma;
	public GameObject tako;
	public GameObject hito;
	public GameObject tuno;
	public int stage;

	public VolcanoScript script;
	public AudioSource dokanSound;
	bool hassya = false;
	bool kanryo = false;



	// Use this for initialization
	void Start () {
		magma.SetActive (false);
		voltage = GameObject.Find("voltage");
		script = voltage.GetComponent<VolcanoScript> ();
		stage = title.stage;
		if (stage == 1) {
			hito.SetActive (false);
			tuno.SetActive (false);
		}
		if (stage == 2) {
			tako.SetActive (false);
			tuno.SetActive (false);
		}
		if (stage == 3) {
			tako.SetActive (false);
			hito.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () {
		float speed = VolcanoScript.tame * 0.5f;
		float timer = script.timer;
		if (hassya == true && kanryo == false) {
			Sound ();
		}
		if (timer >= 3.0f) {
			hassya = true;
			magma.SetActive (true);
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (transform.position.y >= 9) {
			SceneManager.LoadScene ("Main");
		}
	}

	void Sound(){
		dokanSound.Play ();
		kanryo = true;
	}
}
