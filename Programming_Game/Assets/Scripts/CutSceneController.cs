using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutSceneController : MonoBehaviour {

	public Text characterName;
	public Text sceneText;
	public GameObject cutscenePanel;
	public bool isPlayingCutscene = false;
	public Dialogue currentDialogue;

	public Dictionary<string,Dialogue> phrases = new Dictionary<string,Dialogue> ();

	public class Dialogue{
		public string speaker;
		public string text;
		public string nextPhrase;
		public Dialogue(string sp, string txt, string n ){
			speaker = sp + ": ";
			text = txt;
			nextPhrase = n;

		}
	}

	Dialogue end = new Dialogue ("End", "Fin", "end");

	Dialogue c1p1 = new Dialogue ("Eugene", "I'm a snowman", "c1p2");
	Dialogue c1p2 = new Dialogue ("Eugene", "Something", "c1p3");
	Dialogue c1p3 = new Dialogue ("Square", "Something else", "c1p4");
	Dialogue c1p4 = new Dialogue ("Eugene", "Last thing", "end");


	void Start(){
		phrases.Add("end",end);
		phrases.Add("c1p1",c1p1);
		phrases.Add("c1p2",c1p2);
		phrases.Add("c1p3",c1p3);
		phrases.Add("c1p4",c1p4);
		isPlayingCutscene = true;
		DisplayDialogue ("c1p1");
	}



	void Update(){
		if (isPlayingCutscene) {
			if (Input.GetKeyDown (KeyCode.Space)) {

				if (currentDialogue.nextPhrase != "end") {
					DisplayDialogue (currentDialogue.nextPhrase);
				} else {
					isPlayingCutscene = false;
					cutscenePanel.SetActive (false);
				}
			}
		}
	}

	public void DisplayDialogue(string ds){
		Dialogue d = phrases [ds];
		characterName.text = d.speaker;
		sceneText.text = d.text;
		sceneText.text = d.text;
		currentDialogue = d;
	}

}