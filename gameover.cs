using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	// Use this for initialization

	public Text Score;
	public Scoremanager score;
	void Start () {
		score = GameObject.FindObjectOfType<Scoremanager> ();
		Score.text ="Score:= "+ score.Score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onRestartGame(){
		SceneManager.LoadScene ("game");

	}

}
