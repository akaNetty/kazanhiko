using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class title : MonoBehaviour {
	bool go = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (go) {
			transform.position += Vector3.down * 7.0f * Time.deltaTime;
		}
		if (transform.position.y <= -1.449997) {
			SceneManager.LoadScene ("Tame");
		}
	}

	public void start(){
		go = true;
	}
}
