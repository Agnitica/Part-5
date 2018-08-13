using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	// Use this for initialization
	public float hspeed=5.0f;
	public float vspeed=5.0f;
	private bool jump;
	public GameObject fallpoint;
	private Animator animator;
	private Rigidbody2D player;
	void Start () {
		player = GetComponent<Rigidbody2D> ();
		player.velocity = new Vector2 (0, player.velocity.y);
		animator = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.y < fallpoint.transform.position.y) {
			player.velocity=new Vector2 (0, player.velocity.y);
			StartCoroutine ("EndGame");
			}
		player.velocity = new Vector2 (hspeed, player.velocity.y);

		if ((jump)&&(Input.GetKey ("space"))) 
		{    
			player.velocity = new Vector2 (player.velocity.x, vspeed);

			jump = false;

		}  
		animator.SetFloat ("Velocity", player.velocity.x);
		animator.SetBool ("onPlatform", jump);

	


	
	}

	private IEnumerator EndGame(){

		yield return new WaitForSeconds (0.5f);
	
		SceneManager.LoadScene ("gameover");

	}




	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Platform") 
		{
			jump = true;
		}
	}
}
