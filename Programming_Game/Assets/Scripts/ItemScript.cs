using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ItemScript : MonoBehaviour {
	public int itemID = 0;
	public Image img;
	// 0 none
	// 1 red
	// 2 blue
	// 3 yellow
	// 4 green
	// 5 black
	// 6 purple

	Color32 red = new Color32 (255, 0, 0, 255);
	Color32 blue = new Color32 (0, 86, 255, 255);
	Color32 yellow = new Color32 (251, 255, 0, 255);
	Color32 green = new Color32 (0, 255, 30, 255);
	Color32 none = new Color32 (0, 0, 0, 0);
	Color32 stop = new Color32 (156,41,41,255);
	Color32 loop = new Color32 (146, 0, 255,255);



	void Start(){
		img = this.GetComponent<Image> ();
		SetColor (itemID);

	}

	void Update(){
		

	}

	public void SetColor(int col){
		itemID = col;
		Debug.Log ("Color Change");
		if (col == 0) {
			img.color = none;
		} else if (col == 1) {
			img.color = red;
		} else if (col == 2) {
			img.color = blue;
		} else if (col == 3) {
			img.color = yellow;
		} else if (col == 4) {
			img.color = green;
		} else if (col == 5) {
			img.color = stop;
		} else if (col == 6) {
			img.color = loop;
		}
}
}
