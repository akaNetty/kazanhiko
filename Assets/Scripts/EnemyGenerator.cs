using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject[] Syogai;
	public GameObject univers;
	public GameObject kiryuu;
	public GameObject kumo;
	int number;
	int a = 12;
	public int stage;
	float timer =0;
	float meter = 0;
	int flag = 0;
	int Kumo = 0;

	// Use this for initialization
	void Start () {
		float x = Random.Range (-3.0f, 3.0f);
		Instantiate (kumo, new Vector2 (x, 4), transform.rotation);
		stage = title.stage;
		if (stage == 1) {
			
		}
		if (stage == 2) {
			a = 7;
		}
		if (stage == 3) {
			
		}


	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		float speed = ArienScript.speed;
		meter = timer * speed;
		Debug.Log (flag);
		float b = Random.Range (-3.0f, 3.0f);
		if (Kumo == 0) {
			if (meter % 5 <= 0.2f) {
				Instantiate (kumo, new Vector2 (b, 9), transform.rotation);
			}
		}

		if (stage == 1 || stage == 3) {

			if (flag == 0) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a), transform.rotation);
				flag = 1;
			}
			if (flag == 1) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 2), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 2 + 5), transform.rotation);
				flag = 2;
			}
			if (flag == 2) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 3), transform.rotation);
				flag = 3;
			}
			if (flag == 3) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 4), transform.rotation);
				flag = 4;
			}
			if (flag == 4) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 5), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 5 + 5), transform.rotation);
				flag = 5;
			}
			if (flag == 5) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 6), transform.rotation);
				flag = 6;
			}
			if (flag == 6) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 7), transform.rotation);
				flag = 7;
			}
			if (flag == 7) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 8), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 8 + 5), transform.rotation);
				flag = 8;
			}
			if (flag == 8) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 9), transform.rotation);
				flag = 9;
			}
			if (flag == 9) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 10), transform.rotation);
				flag = 10;
			}
			if (flag == 10) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 11), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 11 + 5), transform.rotation);
				flag = 11;
			}
			if (flag == 11) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 12), transform.rotation);
				flag = 12;
			}
			if (flag == 12) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 13), transform.rotation);
				flag = 13;
			}
			if (flag == 13) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 14), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 14 + 5), transform.rotation);
				flag = 14;
			}
			if (flag == 14) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 15), transform.rotation);
				flag = 15;
			}
			if (flag == 15) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 16), transform.rotation);
				flag = 16;
			}
			if (flag == 16) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 17), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 17 + 5), transform.rotation);
				flag = 17;
			}
			if (flag == 17) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 18), transform.rotation);
				flag = 18;
			}
			if (flag == 18) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 19), transform.rotation);
				flag = 19;
			}
			if (flag == 19) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 20), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 20 + 5), transform.rotation);
				flag = 20;
			}
			if (flag == 20) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 21), transform.rotation);
				flag = 21;
			}

			if (flag == 21) {
				univers.transform.position = new Vector3 (0, a * 22, 0);
				univers.transform.eulerAngles = new Vector3 (-180, 0, 0);
				flag = 22;
			}
		} else {
			if (flag == 0) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a), transform.rotation);
				flag = 1;
			}
			if (flag == 1) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 2), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 2 + 5), transform.rotation);
				flag = 2;
			}
			if (flag == 2) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 3), transform.rotation);
				flag = 3;
			}
			if (flag == 3) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 4), transform.rotation);
				flag = 4;
			}
			if (flag == 4) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 5), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 5 + 5), transform.rotation);
				flag = 5;
			}
			if (flag == 5) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 6), transform.rotation);
				flag = 6;
			}
			if (flag == 6) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 7), transform.rotation);
				flag = 7;
			}
			if (flag == 7) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 8), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 8 + 5), transform.rotation);
				flag = 8;
			}
			if (flag == 8) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 9), transform.rotation);
				flag = 9;
			}
			if (flag == 9) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 10), transform.rotation);
				flag = 10;
			}
			if (flag == 10) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (0, 3);
				Instantiate (Syogai [number], new Vector2 (x, a * 11), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 11 + 5), transform.rotation);
				flag = 11;
			}
			if (flag == 11) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 12), transform.rotation);
				flag = 12;
			}
			if (flag == 12) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 13), transform.rotation);
				flag = 13;
			}
			if (flag == 13) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 14), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 14 + 5), transform.rotation);
				flag = 14;
			}
			if (flag == 14) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 15), transform.rotation);
				flag = 15;
			}
			if (flag == 15) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 16), transform.rotation);
				flag = 16;
			}
			if (flag == 16) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 17), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 17 + 5), transform.rotation);
				flag = 17;
			}
			if (flag == 17) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 18), transform.rotation);
				flag = 18;
			}
			if (flag == 18) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 19), transform.rotation);
				flag = 19;
			}
			if (flag == 19) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 20), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 20 + 5), transform.rotation);
				flag = 20;
			}
			if (flag == 20) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 21), transform.rotation);
				flag = 21;
			}
			if (flag == 21) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 22), transform.rotation);
				flag = 22;
			}
			if (flag == 22) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 23), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 25 + 5), transform.rotation);
				flag = 23;
			}
			if (flag == 23) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 24), transform.rotation);
				flag = 24;
			}
			if (flag == 24) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 25), transform.rotation);
				flag = 25;
			}
			if (flag == 25) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 26), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 26 + 5), transform.rotation);
				flag = 26;
			}
			if (flag == 26) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 27), transform.rotation);
				flag = 27;
			}
			if (flag == 27) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 28), transform.rotation);
				flag = 28;
			}
			if (flag == 28) {
				float x = Random.Range (-3.0f, 3.0f);
				number = Random.Range (6, Syogai.Length);
				Instantiate (Syogai [number], new Vector2 (x, a * 29), transform.rotation);
				float x1 = Random.Range (-3.0f, 3.0f);
				Instantiate (kiryuu, new Vector2 (x1, a * 29 + 5), transform.rotation);
				flag = 29;
			}
			if (flag == 30) {
				float x = Random.Range (6, Syogai.Length);
				number = Random.Range (3, 6);
				Instantiate (Syogai [number], new Vector2 (x, a * 31), transform.rotation);
				flag = 31;
			}
			if (flag == 32) {
				univers.transform.position = new Vector3 (0, a * 33, 0);
				univers.transform.eulerAngles = new Vector3 (-180, 0, 0);
				flag = 33;
			}
		}
			
	}

	void Finish(){
		Kumo = 1;
	}
}
