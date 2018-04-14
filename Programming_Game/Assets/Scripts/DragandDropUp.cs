using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDropUp : MonoBehaviour {
	public GameObject iconSlot1;
	public GameObject iconSlot2;
	public GameObject iconSlot3;
	public GameObject iconSlot4;
	public GameObject placeHolder;
	public GameObject bg0;
	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public ButtonPressed bPress;
	public int attachedTo = 0; // Does nothing. Delete at some point.
	float SPX = 0;
	float SPY = 0;
	int oldSlot = 0;



	public void Drag(){
		//Makes icon location equal to mouse while dragging.
		this.transform.position = Input.mousePosition;
	}

	public void Drop(){
		bPress.goesBack = false;
		Vector2 startPos = new Vector2 (SPX, SPY);
		Debug.Log ("Start Pos" + startPos + "");
		//sets distance equal to the distance between this position and iconDrop1 position.
		float distance1 = Vector3.Distance (gameObject.transform.position, iconSlot1.transform.position); 
		Debug.Log (iconSlot1.transform.position);
		float distance2 = Vector3.Distance (this.transform.position, iconSlot2.transform.position);
		float distance3 = Vector3.Distance (this.transform.position, iconSlot3.transform.position);
		float distance4 = Vector3.Distance (this.transform.position, iconSlot4.transform.position);
		//checks the distance between the things
		if (distance1 < 50) {
			//If the distance between the things is small enough, it snaps into place.
			this.transform.position = iconSlot1.transform.position;
			ChangeSlots (1);

		} else if (distance2 < 50) {
			//If the distance between the things is small enough, it snaps into place.
			this.transform.position = iconSlot2.transform.position;
			ChangeSlots (2);

		} else if (distance3 < 50) {
			//If the distance between the things is small enough, it snaps into place.
			this.transform.position = iconSlot3.transform.position;
			ChangeSlots (3);

		} else if (distance4 < 50) {
			//If the distance between the things is small enough, it snaps into place.
			this.transform.position = iconSlot4.transform.position;
			ChangeSlots (4);

		} else {
			this.transform.SetParent(bg0.transform, true);
			this.transform.position = placeHolder.transform.position;
			Debug.Log ("Start Pos" + startPos + "");
			bPress.goesBack = true;
			bPress.selectedSlot = oldSlot;
			// bPress.ButtonPress ("None");
			attachedTo = 0;
			Debug.Log ("Cleared ButtonPress and set selected slot to" + oldSlot + "");
		}
	}
	void ChangeSlots(int newSlot){
		//Clears old slot.
		bPress.selectedSlot = oldSlot;
		bPress.PickSlot ();
		bPress.ButtonPress ("None");
		Debug.Log ("Cleared Slot");
		//Sets the selected time slot to the first one.
		bPress.selectedSlot = newSlot;
		bPress.PickSlot ();
		oldSlot = newSlot;
		attachedTo = bPress.slctedObj;
		if (bPress.slctedObj == 1) {
			this.transform.SetParent(bg1.transform, true);
			Debug.Log ("parented1");
		}
		if (bPress.slctedObj == 2) {
			this.transform.SetParent(bg2.transform, true);
			Debug.Log ("parented2");
		}
		if (bPress.slctedObj == 3) {
			this.transform.SetParent(bg3.transform, true);
			Debug.Log ("parented3");
		}

	}

}

