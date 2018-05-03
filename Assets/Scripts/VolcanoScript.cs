using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolcanoScript : MonoBehaviour {
	public GameObject tamevol; 
	public GameObject hunvol; 
	public GameObject vol; 
	public Image buttonImage;
	public static float tame = 1;
	public int stame = 0;
	public float timer = 0.0f;
	public Sprite voltame;
	// Use this for initialization
	void Start () {
		tamevol.SetActive (false);
		hunvol.SetActive (false);
		buttonImage = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (stame == 1) {
			timer += Time.deltaTime;
			if (timer >= 3.0f) {
				vol.SetActive (false);
				hunvol.SetActive (true);

			}
		}
	}

	public void renda(){
		buttonImage.sprite = voltame; 
		stame = 1;
		tame++;
		Debug.Log (tame);
	}

}
