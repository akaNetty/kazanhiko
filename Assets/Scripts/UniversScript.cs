using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversScript : MonoBehaviour {
	public float speed = 1;
	public GameObject arien;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		speed = ArienScript.speed;
		if (transform.position.y <= -1.8) {
			speed = 0;
			arien.SendMessage ("Stop");
		}

		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}
