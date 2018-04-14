using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {


		public int Slot1 = 0;
		public int Slot2 = 0;
		public int Slot3 = 0;
		public int Slot4 = 0;
		public int tSlot1 = 0;
		public int tSlot2 = 0;
		public int tSlot3 = 0;
		public int tSlot4 = 0;
		// 0 = empty 
		// 1 = up
		// 2 = down
		// 3 = left
		// 4 = right
		// 5 = stop
		// 6 = loop
		enum collision {moving, stuck};
		public GameObject player;
		collision col1 = collision.moving;
		collision col2 = collision.moving;
		collision col3 = collision.moving;
		collision col4 = collision.moving;
		collision col0 = collision.moving;
		public ButtonPressed bPress;
		public int TempSlot = 0;
		public int lastSlot = 0;
		public int actnNm = 0;
		int timer = 100;

		bool isPlaying = true;
		int currentPart;
		int currentSlot;

		//Keep. Make refer to BP

		void Update(){
			if (isPlaying == true) {

				timer--;
				if (timer <= 0) {
					if (currentPart != 4) {
						currentPart++;
						Debug.Log ("Change parts");
						if (currentPart == 2) {
							Debug.Log ("Part2");
							currentSlot = Slot2;
							if ((Slot1 != Slot2)&& (Slot2 != 6)) {
								// if slot 1 is not equal to slot 2, and slot 2 is not equal to loop. That's weird... check second part when you get back. 
								col0 = col2;
							}
						} else if (currentPart == 3) {
							Debug.Log ("Part3");
							currentSlot = Slot3;
							if ((Slot2 != Slot3)&& (Slot2 != 6)) {
								// if slot 2 is not equal to slot 3, and slot 2 is not equal to loop. 
								col0 = col3;
							}
						} else if (currentPart == 4) {
							Debug.Log ("Part4");
							currentSlot = Slot4;
							if ((Slot3 != Slot4)&& (Slot2 != 6)) {
								// if slot 3 is not equal to slot 4, and slot 2 is not equal to loop. This is probably what is causing my collision problem. 
								col0 = col4;
							}
						}
						timer = 100;
					}
				}
				ContinuePlaying ();
			}
		}

		//Move to BP. Collision stuff will get complicated, most likely. 

		public void Play(){
			isPlaying = true;
			//Should figure out how to make play only happen after timer hits 0 again?
			Slot1 = tSlot1;
			Slot2 = tSlot2;
			Slot3 = tSlot3;
			Slot4 = tSlot4;

			currentSlot = Slot1;
			col1 = collision.moving;
			col2 = collision.moving;
			col3 = collision.moving;
			col4 = collision.moving;
			col0 = col1;



			currentPart = 1;
			timer = 100;


		}

		//Move to ButtonPressed

		public void Stop(){
			isPlaying = false;
		}

		//Keep and make refer to BP? I think? Check. 

		void ContinuePlaying(){
			if(col0 == collision.moving){
				if ((currentSlot == 0)&&(lastSlot == 0)) {

				}else if ((currentSlot == 1)||((currentSlot == 0) && (lastSlot == 1))) {
					//If current slot is up, or the current slot is empty and the last slot is up.
					
					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.05f);
					this.transform.position = newPos;
					lastSlot = 1 ; //(up)
				}else if ((currentSlot == 2)||((currentSlot == 0) && (lastSlot == 2))) {
					//If current slot is down, or empty and last was down 
					Debug.Log ("Going up");
					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.05f);
					this.transform.position = newPos;
					lastSlot = 2; //(down)
				}else if ((currentSlot == 3)||((currentSlot == 0) && (lastSlot == 3))) {
					//left
					Debug.Log ("Going left");
					Vector2 newPos = new Vector2 (this.transform.position.x - 0.1f, this.transform.position.y);
					this.transform.position = newPos;
					lastSlot = 3; //(left)
				}else if ((currentSlot == 4)||((currentSlot == 0) && (lastSlot == 4))) {
					//right
					Vector2 newPos = new Vector2 (this.transform.position.x + 0.1f, this.transform.position.y);
					this.transform.position = newPos;
					lastSlot = 4; //(right)
				}else if (currentSlot == 6) {
					currentSlot = Slot1;
					currentPart = 1;
					Debug.Log ("part 1");
					timer = 100;
					Debug.Log ("Looped");
					col0 = col1;
				}else if (currentSlot == 5) {
					isPlaying = false;
				}
			}
		}

		//Keep

		public void AssignModule(int toSlot){
			if (toSlot == 1) {
				if (tSlot1 != 0) { // (!= empty)
					//bPress.Unequip (1);
				}
				tSlot1 = TempSlot;
				TempSlot = 0; //(empty)
			}else if (toSlot == 2) {
				if (tSlot2 != 0) {
					//bPress.Unequip (2);
				}
				tSlot2 = TempSlot;
				TempSlot = 0;
			}else if (toSlot == 3) {
				if (tSlot3 != 0) {
					//bPress.Unequip (3);
				}
				tSlot3 = TempSlot;
				TempSlot = 0;
			}else if (toSlot == 4) {
				if (tSlot4 != 0) {
					//bPress.Unequip (4);
				}
				tSlot4 = TempSlot;
				TempSlot = 0;
			}
		}


		//Keep
		void OnCollisionEnter2D(Collision2D col){
			Debug.Log ("Hitting something");
			if (col.gameObject.tag == "Player"){
				//Explode or something

			}
			if (col.gameObject.tag == "Border") {
				if(currentPart == 1){
					Debug.Log ("Hit border1");
					col0 = collision.stuck;
					Bounce ();
					Debug.Log ("Goto bounce");

				}
				if(currentPart == 2){
					Debug.Log ("Hit border2");
					col0 = collision.stuck;
					Bounce ();
				}
				if(currentPart == 3){
					Debug.Log ("Hit border3");
					col3 = collision.stuck;
					col0 = col3;
					Bounce ();
				}
				if(currentPart == 4){
					Debug.Log ("Hit border4");
					col4 = collision.stuck;
					col0 = col4;
					Bounce ();
				}

			}
		}

		//Keep
		void Bounce(){
			if ((currentSlot == 1) || ((currentSlot == 0) && (lastSlot == 1)) || ((currentSlot == 6) && (lastSlot == 1))) {
				//Up bounce
				Debug.Log ("Bounce Up");
				Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.35f);
				this.transform.position = newPos;
			} else if ((currentSlot == 2) || ((currentSlot == 0) && (lastSlot == 2)) || ((currentSlot == 6) && (lastSlot == 2))) {
				Debug.Log ("Bounce Down");
				Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.35f);
				this.transform.position = newPos;
			} else if ((currentSlot == 3) || ((currentSlot == 0) && (lastSlot == 3)) || ((currentSlot == 6) && (lastSlot == 3))) {
				Debug.Log ("Bounce left");
				Vector2 newPos = new Vector2 (this.transform.position.x + 0.35f, this.transform.position.y);
				this.transform.position = newPos;
			} else if ((currentSlot == 4) || ((currentSlot == 0) && (lastSlot == 4)) || ((currentSlot == 6) && (lastSlot == 4))) {
				Debug.Log ("Bounce right");
				Vector2 newPos = new Vector2 (this.transform.position.x - 0.35f, this.transform.position.y);
				this.transform.position = newPos;

			}
		}
	}