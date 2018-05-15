using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class title : MonoBehaviour {
	bool go = false;
	public AudioSource okSound;
	public AudioSource backSound;
	public GameObject ufo;
	public Animator ufoaway;
	public GameObject selectbutton;
	public GameObject rankingbutton;
	public GameObject titletext;
	public GameObject sta1;
	public GameObject sta2;
	public GameObject sta3;
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public GameObject star11;
	public GameObject star21;
	public GameObject star31;
	public GameObject tako;
	public GameObject hito;
	public GameObject tuno;
	public GameObject modoru;
	public GameObject rankingpanel;
	public Text ii;
	public Text aru;
	public Text sen;
	public Text sue;
	public Text uu;
	public float iti = 99999;
	public float ni = 99999;
	public float san = 99999;
	public float yon = 99999;
	public float gou = 99999;

	public static int stage = 1;

	// Use this for initialization
	void Start () {
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
		star11.SetActive (false);
		star21.SetActive (false);
		star31.SetActive (false);
		modoru.SetActive (false);
		rankingpanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		iti = TimeScript.iti;
		ni = TimeScript.ni;
		san = TimeScript.san;
		yon = TimeScript.yon;
		gou = TimeScript.gou;
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

	public void ranking(){
		okSound.Play();
		selectbutton.SetActive (false);
		rankingbutton.SetActive (false);
		modoru.SetActive (true);
		star11.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (true);
		rankingpanel.SetActive (true);
		ii.text = iti.ToString("f1");
		aru.text = ni.ToString("f1");
		sen.text = san.ToString("f1");
		sue.text = yon.ToString("f1");
		uu.text = gou.ToString("f1");
	}

	public void stager1(){
		okSound.Play();
		star1.SetActive (false);
		star2.SetActive (true);
		star3.SetActive (true);
		star11.SetActive (true);
		star21.SetActive (false);
		star31.SetActive (false);
		ii.text = iti.ToString("f1");
		aru.text = ni.ToString("f1");
		sen.text = san.ToString("f1");
		sue.text = yon.ToString("f1");
		uu.text = gou.ToString("f1");

	}

	public void stager2(){
		okSound.Play();
		star1.SetActive (true);
		star2.SetActive (false);
		star3.SetActive (true);
		star11.SetActive (false);
		star21.SetActive (true);
		star31.SetActive (false);
		ii.text = iti.ToString("f1");
		aru.text = ni.ToString("f1");
		sen.text = san.ToString("f1");
		sue.text = yon.ToString("f1");
		uu.text = gou.ToString("f1");
	}

	public void stager3(){
		okSound.Play();
		star1.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (false);
		star11.SetActive (false);
		star21.SetActive (false);
		star31.SetActive (true);
		ii.text = iti.ToString("f1");
		aru.text = ni.ToString("f1");
		sen.text = san.ToString("f1");
		sue.text = yon.ToString("f1");
		uu.text = gou.ToString("f1");

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
		backSound.Play();
		selectbutton.SetActive (true);
		rankingbutton.SetActive (true);
		titletext.SetActive (true);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		star1.SetActive (false);
		star2.SetActive (false);
		star3.SetActive (false);
		star11.SetActive (false);
		star21.SetActive (false);
		star31.SetActive (false);
		rankingpanel.SetActive (false);
		modoru.SetActive (false);

	}

}
