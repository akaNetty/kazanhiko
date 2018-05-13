using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlider : MonoBehaviour {
	public int stage;
	int sayu = 0;
	public float speed = 1;
	float timer = 0;

	// Use this for initialization
	void Start () {
		stage = title.stage;
		if (stage == 3) {
			if (transform.position.x <= 0) {
				sayu = 1;
			} else {
				sayu = 2;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (sayu == 1) {
			right ();
		} else if(sayu == 2) {
			left ();
		}
		speed = ArienScript.speed;

		timer += Time.deltaTime;

	}
	void right(){
		if (transform.position.y <= 2.0f) {
			transform.position += Vector3.right * speed * Time.deltaTime * 0.2f;
		}
	}

	void left(){
		if (transform.position.y <= 2.0f) {
			transform.position += Vector3.left * speed * Time.deltaTime * 0.2f;
		}
	}
}
