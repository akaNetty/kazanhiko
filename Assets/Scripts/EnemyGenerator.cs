using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject[] Syogai;
	int number;
	// Use this for initialization
	void Start () {
		number = Random.Range (0, Syogai.Length);
		Instantiate(Syogai[number],transform.position,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
