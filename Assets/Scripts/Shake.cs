using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShakeObject()
	{
		iTween.ShakePosition(gameObject, iTween.Hash("x", 0.3f, "y", 0.3f, "time", 0.5f));
	}
}
