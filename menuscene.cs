using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscene : MonoBehaviour {

	// Use this for initialization

	public Scoremanager sc=Scoremanager.Instance;



	public void onPress()
	{
		SceneManager.LoadScene ("game");
	
	}

}
