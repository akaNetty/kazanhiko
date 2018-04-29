using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoScript : MonoBehaviour {
	public GameObject tamevol; 
	public GameObject hunvol; 
	bool tame = false;
	bool hunka = false;
	// Use this for initialization
	void Start () {
		tamevol.SetActive (false);
		hunvol.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (tame) {
			bido ();
		}
		if (hunka) {
			hassya ();
		}
	}

	public void PushDown(){
		tame = true;
	}

	public void PushUp(){
		tame = false;
		hunka = true;
	}

	void bido(){
		tamevol.SetActive (true);
	}

	void hassya(){
		hunvol.SetActive (true);
	}
}
