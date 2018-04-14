using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour {
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;
	public ItemScript equip1;
	public ItemScript equip2;
	public ItemScript equip3;
	public ItemScript equip4;
	public int amt1 = 1;
	public int amt2 = 1;
	public int amt3 = 1;
	public int amt4 = 2;
	public int amt5 = 1;
	public int amt6 = 1;

	public void UpdateInventory(int id){
		if (id == 1) {
			Debug.Log ("Subtract Up from Inv");
			amt1--;
		}else if (id == 2) {
			amt2--;
		}else if (id == 3) {
			amt3--;
		}else if (id == 4) {
			amt4--;
		}else if (id == 5) {
			amt5--;
		}else if (id == 6) {
			amt6--;
		}

		item1.SetActive (true);
		item2.SetActive (true);
		item3.SetActive (true);
		item4.SetActive (true);
		item5.SetActive (true);
		item6.SetActive (true);

		if (amt1 <= 0) {
			item1.SetActive (false);
		}
		if (amt2 <= 0) {
			item2.SetActive (false);
		}
		if (amt3 <= 0) {
			item3.SetActive (false);
		}
		if (amt4 <= 0) {
			item4.SetActive (false);
		}
		if (amt5 <= 0) {
			item5.SetActive (false);
		}
		if (amt6 <= 0) {
			item6.SetActive (false);
		}
	}

	public void AddToInv(int id){
		Debug.Log ("AddtoInv 1");
		Debug.Log ("Id: " + id + "");
		if (id == 1) {
			Debug.Log ("" + amt1 + "");
			amt1++;
			Debug.Log ("" + amt1 + "");
		}else if (id == 2) {
			amt2++;
		}else if (id == 3) {
			amt3++;
		}else if (id == 4) {
			amt4++;
		}else if (id == 5) {
			amt5++;
		}else if (id == 6) {
			amt6++;
		}
	}
}
