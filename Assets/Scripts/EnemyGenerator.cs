using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject[] Syogai;
	public GameObject univers;
	public GameObject kiryuu;
	public GameObject kumo;
	int number;
	float timer =0;
	float meter = 0;
	int flag = 0;
	int Kumo = 0;

	// Use this for initialization
	void Start () {
		float x = Random.Range (-3.0f, 3.0f);
		Instantiate (kumo, new Vector2 (x, 4), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		float speed = ArienScript.speed;
		meter = timer * speed;
		Debug.Log (flag);

		float x = Random.Range (-3.0f, 3.0f);
		if (Kumo == 0) {
			if (meter % 5 <= 0.2f) {
				Instantiate (kumo, new Vector2 (x, 9), transform.rotation);
			}
		}


		if (meter <= 10 && flag ==0) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 1;
		}
		if (meter > 10 && meter <= 20 && flag ==1) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,13),transform.rotation);
			flag = 2;
		}
		if (meter > 20 && meter <=30 && flag ==2) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 3;
		}
		if (meter > 30 && meter <=40 && flag ==3) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 4;
		}
		if (meter > 40 && meter <=50 && flag ==4) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,13),transform.rotation);
			flag = 5;
		}
		if (meter > 50 && meter <=60 && flag ==5) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 6;
		}
		if (meter > 60 && meter <=70 && flag ==6) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 7;
		}
		if (meter > 70 && meter <=80 && flag ==7) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,13),transform.rotation);
			flag = 8;
		}
		if (meter > 80 && meter <=100 && flag ==8) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,9),transform.rotation);
			flag = 9;
		}
		if (meter > 120 && flag ==9) {
			univers.transform.position = new Vector3 (0, 9,0);
			univers.transform.eulerAngles = new Vector3(-180, 0, 0);
			flag = 10;
		}
	}

	void Finish(){
		Kumo = 1;
	}
}
