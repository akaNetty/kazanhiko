using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class title : MonoBehaviour {
	bool go = false;
	public AudioSource okSound;
	public GameObject ufo;
	public Animator ufoaway;
	public GameObject selectbutton;
	public GameObject rankingbutton;
	public GameObject titletext;
	public GameObject sta1;
	public GameObject sta2;
	public GameObject sta3;
	public GameObject tako;
	public GameObject hito;
	public GameObject tuno;
	public GameObject modoru;
	public static int stage = 1;

	// Use this for initialization
	void Start () {
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		modoru.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (go) {
			ufo.SendMessage ("away");
			if (transform.position.y >= -1.36f) {
					transform.position += Vector3.down * 7.0f * Time.deltaTime;
				}
			}
		if (transform.position.y < -1.36f) {
			SceneManager.LoadScene ("Tame");
		}
	}

	public void start(){
		go = true;
		okSound.Play();
		ufoaway.SetBool ("away",true);
	}

	public void selectstage(){
		okSound.Play();
		selectbutton.SetActive (false);
		rankingbutton.SetActive (false);
		titletext.SetActive (false);
		sta1.SetActive (true);
		sta2.SetActive (true);
		sta3.SetActive (true);
		modoru.SetActive (true);
	}

	public void  stage1(){
		stage = 1;
		hito.SetActive (false);
		tuno.SetActive (false);
		start ();
	}

	public void  stage2(){
		stage = 2;
		tako.SetActive (false);
		tuno.SetActive (false);
		start ();
	}

	public void  stage3(){
		stage = 3;
		tako.SetActive (false);
		hito.SetActive (false);
		start ();
	}

	public void back(){
		selectbutton.SetActive (true);
		rankingbutton.SetActive (true);
		titletext.SetActive (true);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		modoru.SetActive (false);
	}

}
