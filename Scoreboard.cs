using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Scoreboard : MonoBehaviour {


	public Player player;
	private Vector3 prevpos;
	public Text Score;
	private int dis=0;
	//private static Scoreboard instance;
	public Scoremanager sc;

	// Use this for initialization





	void Start () {
		prevpos = player.transform.position;
		sc = GameObject.FindObjectOfType<Scoremanager> ();

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(player!=null)
		{
			dis=(int)Math.Ceiling(dis+player.transform.position.x - prevpos.x);
	    	Score.text = "Score: " + dis;
			sc.Score=dis;
		
			prevpos = player.transform.position;
		
		
		}

		
	}
}
