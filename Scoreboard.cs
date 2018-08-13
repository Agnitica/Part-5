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
	

	// Use this for initialization

	void Start () {
		prevpos = player.transform.position;
		

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(player!=null)
		{
			dis=(int)Math.Ceiling(dis+player.transform.position.x - prevpos.x);
	    	      Score.text = "Score: " + dis;
			
			prevpos = player.transform.position;
		
		
		}

		
	}
}
