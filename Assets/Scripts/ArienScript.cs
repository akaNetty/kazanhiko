using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArienScript : MonoBehaviour {
	GameObject arien;
	float avoid = 3.0f;
	bool lefty = false;
	bool righty = false;
	public static float  speed = 1;



	// Use this for initialization
	void Start () {
		speed = VolcanoScript.tame * 0.5f;
	}

	// Update is called once per frame
	void Update () {
		
		if(righty){
			right();
		}
		if(lefty){
			left();
		}
	}

	public void rPushDown(){
		righty = true;
	}

	public void rPushUp(){
		righty = false;
	}

	public void lPushDown(){
		lefty = true;
	}

	public void lPushUp(){
		lefty = false;
	}



	public void left(){
		if (transform.position.x >= -2.5) {
			transform.position += new Vector3 (-avoid * Time.deltaTime, 0, 0);
		}
	}

	public void right(){
		if (transform.position.x <= 2.5) {
			transform.position += new Vector3 (avoid * Time.deltaTime, 0, 0);
		}
	}

	public void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Enemy") {
			if (speed > 1) {
				speed--;
			}
			Destroy (other.gameObject);
		} else if (other.tag == "Kiryu") {
			speed++;
			Destroy (other.gameObject);
		}
	}



}

