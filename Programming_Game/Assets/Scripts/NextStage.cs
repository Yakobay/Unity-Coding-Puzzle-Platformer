using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour {

	public PlayerScript ph;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (ph.Died == true) {
			//go to death scene
			Debug.Log("Died");
		}
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
	SceneManager.LoadScene (1);

			//If you could do LoadScene(scene+1); somehow, that would be great.
		}
	}

}