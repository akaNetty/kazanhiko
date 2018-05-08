using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolcanoScript : MonoBehaviour {
	public GameObject tamevol; 
	public GameObject hunvol; 
	public GameObject vol; 
	public Animator animator;
	public Text text;
	public Image buttonImage;
	public static float tame = 1;
	public int stame = 0;
	public float jikan = 0.0f;
	public float timer = 0.0f;
	public float nokori = 3.0f;
	public Sprite voltame;
	// Use this for initialization
	void Start () {
		tamevol.SetActive (false);
		hunvol.SetActive (false);
		buttonImage = this.GetComponent<Image>();
		tame = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (stame == 1) {
			timer += Time.deltaTime;
			nokori = 3.0f-timer;
			text.text =  "あと" +nokori.ToString ("f1");
			if (timer >= 3.0f) {
				vol.SetActive (false);
				hunvol.SetActive (true);

			}
		}
	}

	public void renda(){
//		vol.gameObject.transform.localScale = new Vector3 (1.2f, 2.2f, 0);
		buttonImage.sprite = voltame; 
		stame = 1;
		tame++;
		Debug.Log (tame);
		vol.SendMessage ("Vibe");
		animator.SetTrigger ("dokan");
//		vol.gameObject.transform.localScale = new Vector3 (1.0f, 1.8f, 0);
	}

}
