//ButtonPressed 

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour {

	public GameObject bg1;
	public GameObject bg2;
	public GameObject bg3;
	public DragandDrop dandd;
	//Time slots. Which goes first, second, third, fourth, etc. I think??
	public int slot = 0;
	//Whatever is in the time slot? IDK. It's related to the slot toggles. 
	public GameObject item0;
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject currentItem;
	//The Object being controlled. See cursor code. 
	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject currentObject;
	public GameObject lastObject;
	public int slctedObj = 1;
	public int actn;
	public int selectedSlot;
	public int PlayCharges = 3;
	public Text playCount;
	//Used in drag and drop:
	public bool goesBack = false;



	//Have something check on start/code switch, if the Slots have value.

	void Start(){
		currentObject = obj1;
		Debug.Log ("Called NLS1");
		NewLiftScript nlif = currentObject.GetComponent<NewLiftScript> ();
		Debug.Log ("Called NLS");
		if (currentObject == obj1) {
			CheckInv();
			lastObject = obj1;
			slctedObj = 1;
			bg1.SetActive (true);
			bg2.SetActive (false);
			bg3.SetActive (false);
			Debug.Log ("TFF");
		} else if (currentObject == obj2) {
			CheckInv();
			lastObject = obj2;
			slctedObj = 2;
			bg2.SetActive (true);
			bg1.SetActive (false);
			bg3.SetActive (false);
			Debug.Log ("FTF");
		} else if (currentObject == obj3) {
			CheckInv();
			lastObject = obj3;
			slctedObj = 3;
			bg3.SetActive (true);
			bg2.SetActive (false);
			bg1.SetActive (false);
			Debug.Log ("FFT");
	
		}
	}

		void Update(){
			if (currentObject != lastObject) {
				Debug.Log ("No Match");
			if (currentObject == obj1) {
				CheckInv();
				lastObject = obj1;
				slctedObj = 1;
				bg1.SetActive (true);
				bg2.SetActive (false);
				bg3.SetActive (false);
				Debug.Log ("IS" + bg1.activeSelf + "");
				Debug.Log ("TFF");
			} else if (currentObject == obj2) {
				CheckInv();
				lastObject = obj2;
				slctedObj = 2;
				bg2.SetActive (true);
				bg1.SetActive (false);
				bg3.SetActive (false);
				Debug.Log ("IS" + bg1.activeSelf + "");
				Debug.Log ("FTF");
			} else if (currentObject == obj3) {
				CheckInv();
				lastObject = obj3;
				slctedObj = 3;
				bg3.SetActive (true);
				bg2.SetActive (false);
				bg1.SetActive (false);
				Debug.Log ("IS" + bg1.activeSelf + "");
				Debug.Log ("FFT");
			}

		}
		NewLiftScript nlif = currentObject.GetComponent<NewLiftScript> ();

	}



	public void PickSlot(){ //Called when toggle changes value. Change to call on drop. 
		if (selectedSlot == 0) {
			currentItem = item0;
		}if (selectedSlot == 1) {
			currentItem = item1;
		} else if (selectedSlot == 2) {
			currentItem = item2;
		} else if (selectedSlot == 3) {
			currentItem = item3;
		} else if (selectedSlot == 4) {
			currentItem = item4;
		}
	}

	public void ButtonPress(string whichButton){
		NewLiftScript nlif = currentObject.GetComponent<NewLiftScript> ();
		if (whichButton == "Play") {
			if (PlayCharges > 0) {
				nlif.Play ();
			}
			PlayCharges--;
			playCount.text = "Charges: " + PlayCharges;
		}

		ItemScript iScript = currentItem.GetComponent<ItemScript> ();

		nlif.TempSlot = 0;

		if (goesBack == false) {
			//Finds out which button/command was used
			if (whichButton == "Up") {
				actn = 1;
			} else if (whichButton == "Down") {
				actn = 2;
			} else if (whichButton == "Left") {
				actn = 3;
			} else if (whichButton == "Right") {
				actn = 4;
			} else if (whichButton == "None") {
				actn = 0;
			} else if (whichButton == "Stop") {
				actn = 5;
			} else if (whichButton == "Loop") {
				actn = 6;

			}
			Debug.Log (whichButton + " set to actn");
		} else {
			actn = 0;
		}
		//Sets tempSlot to command/button number
		nlif.TempSlot = actn;
		nlif.AssignModule (selectedSlot);
		//Changes colors
		iScript.SetColor (actn);
		Debug.Log ("Set Color" + actn + "");
		//this.gameObject.GetComponent<InventoryManager> ().UpdateInventory (currentItem.GetComponent<ItemScript> ().itemID);

	}



//	public void Unequip(int slotID){
//		if (slotID == 1) {
//			this.gameObject.GetComponent<InventoryManager> ().AddToInv(item1.GetComponent<ItemScript>().itemID);
//			Debug.Log ("Unequipped" + item1.GetComponent<ItemScript> ().itemID);
//		}else if (slotID == 2) {
//			this.gameObject.GetComponent<InventoryManager> ().AddToInv(item2.GetComponent<ItemScript>().itemID);
//		}else if (slotID == 3) {
//			this.gameObject.GetComponent<InventoryManager> ().AddToInv(item3.GetComponent<ItemScript>().itemID);
//		}else if (slotID == 4) {
//			this.gameObject.GetComponent<InventoryManager> ().AddToInv(item4.GetComponent<ItemScript>().itemID);
//		}
//	}
//
	void CheckInv(){
	NewLiftScript nlif = currentObject.GetComponent<NewLiftScript> ();
			if (nlif.tSlot1 != 500) { //Always true
				ItemScript iScript = item1.GetComponent<ItemScript> ();
				iScript.SetColor (nlif.tSlot1);
			}
			if (nlif.tSlot2 != 500) {
				ItemScript iScript = item2.GetComponent<ItemScript> ();
				iScript.SetColor (nlif.tSlot2);
			}
			if (nlif.tSlot3 != 500) {
				ItemScript iScript = item3.GetComponent<ItemScript> ();
				iScript.SetColor (nlif.tSlot3);
			}
			if (nlif.tSlot4 != 500) {
				ItemScript iScript = item4.GetComponent<ItemScript> ();
				iScript.SetColor (nlif.tSlot4);
			}

		//Why won't the slots change color for the second and third items when you remove the code-y thingy?

	}
		

}