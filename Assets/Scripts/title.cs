using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class title : MonoBehaviour {
	bool go = false;
	public AudioSource okSound;
	public AudioSource backSound;
	public AudioSource bgmSound;
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
	public GameObject hitori;
	public GameObject zenkoku;
	public GameObject zensta3;
	public GameObject seiseki;
	public GameObject arina;
	public GameObject hitna;
	public GameObject tunna;
	public GameObject zenna;
	public Text Caption;
	public Text ii;
	public Text aru;
	public Text sen;
	public Text sue;
	public Text uu;
	public static float itis1 = 99999;
	public static float nis1 = 99999;
	public static float sans1 = 99999;
	public static float yons1 = 99999;
	public static float gous1 = 99999;
	public static float itis2 = 99999;
	public static float nis2 = 99999;
	public static float sans2 = 99999;
	public static float yons2 = 99999;
	public static float gous2 = 99999;
	public static float itis3 = 99999;
	public static float nis3 = 99999;
	public static float sans3 = 99999;
	public static float yons3 = 99999;
	public static float gous3 = 99999;
	public static int stage = 1;
	public static int rank = 1;


	// Use this for initialization
	void Start () {
//		bgmSound.Play ();
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
		hitori.SetActive (false);
		zenkoku.SetActive (false);
		zensta3.SetActive (false);
		seiseki.SetActive (false);
		arina.SetActive (false);
		hitna.SetActive (false);
		tunna.SetActive (false);
		zenna.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		itis1 = TimeScript.itis1;
		nis1 = TimeScript.nis1;
		sans1 = TimeScript.sans1;
		yons1 = TimeScript.yons1;
		gous1 = TimeScript.gous1;
		itis2 = TimeScript.itis2;
		nis2 = TimeScript.nis2;
		sans2 = TimeScript.sans2;
		yons2 = TimeScript.yons2;
		gous2 = TimeScript.gous2;
		itis3 = TimeScript.itis3;
		nis3 = TimeScript.nis3;
		sans3 = TimeScript.sans3;
		yons3 = TimeScript.yons3;
		gous3 = TimeScript.gous3;
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
		hitori.SetActive (true);
		zenkoku.SetActive (true);
	}

	public void ranking(){
		okSound.Play();
		selectbutton.SetActive (false);
		rankingbutton.SetActive (false);
		titletext.SetActive (false);
		modoru.SetActive (true);
		star11.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (true);
		seiseki.SetActive (true);
		rankingpanel.SetActive (true);
		Caption.text = "STAGE 1";
		if (itis1 != 99999) {
			ii.text = itis1.ToString ("f1");
		} else {
			ii.text = ("ーーー");
		}
		if (nis1 != 99999) {
			aru.text = nis1.ToString("f1");
		}else {
			aru.text = ("ーーー");
		}
		if (sans1 != 99999) {
			sen.text = sans1.ToString ("f1");
		}else {
			sen.text = ("ーーー");
		}
		if (yons1 != 99999) {
			sue.text = yons1.ToString ("f1");
		}else {
			sue.text = ("ーーー");
		}
		if (gous1 != 99999) {
			uu.text = gous1.ToString ("f1");
		}else {
			uu.text = ("ーーー");
		}
	}

	public void stager1(){
		okSound.Play();
		star1.SetActive (false);
		star2.SetActive (true);
		star3.SetActive (true);
		star11.SetActive (true);
		star21.SetActive (false);
		star31.SetActive (false);
		Caption.text = "STAGE 1";
		if (itis1 != 99999) {
			ii.text = itis1.ToString ("f1");
		} else {
			ii.text = ("ーーー");
		}
		if (nis1 != 99999) {
			aru.text = nis1.ToString("f1");
		}else {
			aru.text = ("ーーー");
		}
		if (sans1 != 99999) {
			sen.text = sans1.ToString ("f1");
		}else {
			sen.text = ("ーーー");
		}
		if (yons1 != 99999) {
			sue.text = yons1.ToString ("f1");
		}else {
			sue.text = ("ーーー");
		}
		if (gous1 != 99999) {
			uu.text = gous1.ToString ("f1");
		}else {
			uu.text = ("ーーー");
		}
	}

	public void stager2(){
		okSound.Play();
		star1.SetActive (true);
		star2.SetActive (false);
		star3.SetActive (true);
		star11.SetActive (false);
		star21.SetActive (true);
		star31.SetActive (false);
		Caption.text = "STAGE 2";
		if (itis2 != 99999) {
			ii.text = itis2.ToString ("f1");
		} else {
			ii.text = ("ーーー");
		}
		if (nis2 != 99999) {
			aru.text = nis2.ToString("f1");
		}else {
			aru.text = ("ーーー");
		}
		if (sans2 != 99999) {
			sen.text = sans2.ToString ("f1");
		}else {
			sen.text = ("ーーー");
		}
		if (yons2 != 99999) {
			sue.text = yons2.ToString ("f1");
		}else {
			sue.text = ("ーーー");
		}
		if (gous2 != 99999) {
			uu.text = gous2.ToString ("f1");
		}else {
			uu.text = ("ーーー");
		}
	}

	public void stager3(){
		okSound.Play();
		star1.SetActive (true);
		star2.SetActive (true);
		star3.SetActive (false);
		star11.SetActive (false);
		star21.SetActive (false);
		star31.SetActive (true);
		Caption.text = "STAGE 3";
		if (itis3 != 99999) {
			ii.text = itis3.ToString ("f1");
		} else {
			ii.text = ("ーーー");
		}
		if (nis3 != 99999) {
			aru.text = nis3.ToString("f1");
		}else {
			aru.text = ("ーーー");
		}
		if (sans3 != 99999) {
			sen.text = sans3.ToString ("f1");
		}else {
			sen.text = ("ーーー");
		}
		if (yons3 != 99999) {
			sue.text = yons3.ToString ("f1");
		}else {
			sue.text = ("ーーー");
		}
		if (gous3 != 99999) {
			uu.text = gous3.ToString ("f1");
		}else {
			uu.text = ("ーーー");
		}
	}

	public void  stage1(){
		stage = 1;
		rank = 1;
		hito.SetActive (false);
		tuno.SetActive (false);
		arina.SetActive (true);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		start ();
	}

	public void  stage2(){
		stage = 2;
		rank = 1;
		tako.SetActive (false);
		tuno.SetActive (false);
		hitna.SetActive (true);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		start ();
	}

	public void  stage3(){
		stage = 3;
		rank = 1;
		tako.SetActive (false);
		hito.SetActive (false);
		tunna.SetActive (true);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
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
		hitori.SetActive (false);
		zenkoku.SetActive (false);
		zensta3.SetActive (false);
		seiseki.SetActive (false);
		zenna.SetActive (false);
	}

	public void hitor(){
		okSound.Play();
		selectbutton.SetActive (false);
		rankingbutton.SetActive (false);
		titletext.SetActive (false);
		sta1.SetActive (true);
		sta2.SetActive (true);
		sta3.SetActive (true);
		modoru.SetActive (true);
		zensta3.SetActive (false);

	}

	public void zenkok(){
		okSound.Play();
		selectbutton.SetActive (false);
		rankingbutton.SetActive (false);
		titletext.SetActive (false);
		sta1.SetActive (false);
		sta2.SetActive (false);
		sta3.SetActive (false);
		modoru.SetActive (true);
		zensta3.SetActive (true);
	}

	public void zen3(){
		stage = 3;
		rank = 2;
		tako.SetActive (false);
		hito.SetActive (false);
		zenna.SetActive (true);
		zensta3.SetActive (false);
		start ();
	}
}
