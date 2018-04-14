using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int PlayerHealth = 1;
	public bool Died = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerHealth < 1) {
			Died = true;
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Border") {
			PlayerHealth--;
		}
	}
}
