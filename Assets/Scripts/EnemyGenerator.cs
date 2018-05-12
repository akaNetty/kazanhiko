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

		if (flag ==0) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,12),transform.rotation);
			flag = 1;
		}
		if (flag ==1) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,12*2),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,12*2+5),transform.rotation);
			flag = 2;
		}
		if (flag ==2) {
			number = Random.Range (0, 3);
			Instantiate(Syogai[number],new Vector2(x,12*3),transform.rotation);
			flag = 3;
		}
		if (flag ==3) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,12*4),transform.rotation);
			flag = 4;
		}
		if (flag ==4) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,12*5),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,12*5+5),transform.rotation);
			flag = 5;
		}
		if (flag ==5) {
			number = Random.Range (3, 6);
			Instantiate(Syogai[number],new Vector2(x,12*6),transform.rotation);
			flag = 6;
		}
		if (flag ==6) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,12*7),transform.rotation);
			flag = 7;
		}
		if (flag ==7) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,12*8),transform.rotation);
			float x1 = Random.Range (-3.0f, 3.0f);
			Instantiate(kiryuu,new Vector2(x1,12*8+5),transform.rotation);
			flag = 8;
		}
		if (flag ==8) {
			number = Random.Range (6, Syogai.Length);
			Instantiate(Syogai[number],new Vector2(x,12*9),transform.rotation);
			flag = 9;
		}
		if (flag ==9) {
			univers.transform.position = new Vector3 (0, 12*10,0);
			univers.transform.eulerAngles = new Vector3(-180, 0, 0);
			flag = 10;
		}
	}

	void Finish(){
		Kumo = 1;
	}
}
