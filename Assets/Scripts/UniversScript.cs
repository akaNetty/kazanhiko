using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversScript : MonoBehaviour {
	public float speed = 1;
	public GameObject time;
	public GameObject EnemyGenerator;
	public Slider height;
	public float kyori = 264;
	public float takasa = 0;
	public int stage;
	public int flag=1;
	public static int bfl = 1;


	// Use this for initialization
	void Start () {
		height = GameObject.Find("Height").GetComponent<Slider>();
		stage = title.stage;
	}
	
	// Update is called once per frame
	void Update () {
		if (stage == 2) {
			kyori = 231;
		}
		height.maxValue = kyori;
		Debug.Log (kyori);
		takasa = kyori - transform.position.y + 1.8f;
		height.value = takasa;
		speed = ArienScript.speed;
		if (transform.position.y <= -1.8) {
			speed = 0;
			if (flag == 1) {
				time.SendMessage ("Stop");
				bfl = 2;
				flag = 2;
			}
		}
		if (transform.position.y <= -0.8) {
			EnemyGenerator.SendMessage("Finish");
		}

		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}
