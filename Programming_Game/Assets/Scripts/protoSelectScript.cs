using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protoSelectScript : MonoBehaviour {

	public ButtonPressed bPress;

	//This solution is not scalable. I'd have to make a script for literally every selectable object in a scene, and that's a no-no. It's a temporary solution.
	//See if you can figure out a way to make one script (preferably something I can put in NewLiftScript), which can figure out which object it's part of.
	void OnMouseOver(){
		if (Input.GetMouseButton(0))
		{
			bPress.currentObject = bPress.obj2;
			Debug.Log ("set to obj2");
		}
	}

}
