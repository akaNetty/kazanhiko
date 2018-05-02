using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public float speed = 1;
	float timer = 0;
	float meter = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		speed = ArienScript.speed;
	
		timer += Time.deltaTime;
		meter = timer * speed;
		Debug.Log (meter);

		transform.position += Vector3.down * speed * Time.deltaTime;
	}
}
