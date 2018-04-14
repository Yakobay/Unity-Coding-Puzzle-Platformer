//using UnityEngine;
//using System.Collections;
//
//public class LiftScript : MonoBehaviour {
//	public bool Play = false;
//	public bool none = false;
//	public bool action1 = false;
//	public bool action2 = false;
//	public bool action3 = false;
//	public bool action4 = false;
//	public bool up = false;
//	public bool down = false;
//	public bool left = false;
//	public bool right = false;
//	public bool stop = false;
//	public bool loop = false;
//	public bool up1 = false;
//	public bool down1 = false;
//	public bool left1 = false;
//	public bool right1 = false;
//	public bool stop1 = false;
//	public bool loop1 = false;
//	public bool up2 = false;
//	public bool down2 = false;
//	public bool left2 = false;
//	public bool right2 = false;
//	public bool stop2 = false;
//	public bool loop2 = false;
//	public bool up3 = false;
//	public bool down3 = false;
//	public bool left3 = false;
//	public bool right3 = false;
//	public bool stop3 = false;
//	public bool loop3 = false;
//	public bool up4 = false;
//	public bool down4 = false;
//	public bool left4 = false;
//	public bool right4 = false;
//	public bool stop4 = false;
//	public bool loop4 = false;
//	public int timer = 50;
//	public bool part1 = true;
//	public bool part2 = false;
//	public bool part3 = false;
//	public bool part4 = false;
//	public bool part5 = false;
//	public bool has2 = false;
//	public bool has3 = false;
//	public bool has4 = false;
//	public bool upMode1 = false;
//	public bool downMode1 = false;
//	public bool rightMode1 = false;
//	public bool leftMode1 = false;
//	public bool upMode2 = false;
//	public bool downMode2 = false;
//	public bool rightMode2 = false;
//	public bool leftMode2 = false;
//	public bool upMode3 = false;
//	public bool downMode3 = false;
//	public bool rightMode3 = false;
//	public bool leftMode3 = false;
//	public bool upMode4 = false;
//	public bool downMode4 = false;
//	public bool rightMode4 = false;
//	public bool leftMode4 = false;
//	public bool WillPlay = false;
//	public bool Reset = false;
//	public bool upCont1 = false;
//	public bool downCont1 = false;
//	public bool leftCont1 = false;
//	public bool rightCont1 = false;
//	public bool upCont2 = false;
//	public bool downCont2 = false;
//	public bool leftCont2 = false;
//	public bool rightCont2 = false;
//	public bool upCont3 = false;
//	public bool downCont3 = false;
//	public bool leftCont3 = false;
//	public bool rightCont3 = false;
//	public bool upCont4 = false;
//	public bool downCont4 = false;
//	public bool leftCont4 = false;
//	public bool rightCont4 = false;
//
//	public enum slot {empty, up, down, right, left, loop, stop};
//	public slot Slot1 = slot.empty;
//	public slot Slot2 = slot.empty;
//	public slot Slot3 = slot.empty;
//	public slot Slot4 = slot.empty;
//
//	public GameObject Lift;
//
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (WillPlay) {
//			Play = true;
//			WillPlay = false;
//		}
//
//		if (Reset) {
//			ResetLift ();
//		}
//		//if (Play == false) {
//			if ((action1) && (up)) {
//				Debug.Log ("Something went wrong 1");
//				up1 = true;
//				left1 = false;
//				right1 = false;
//				down1 = false;
//				stop1 = false;
//				loop1 = false;
//				upMode1 = true;
//				upCont1 = true;
//				downCont1 = false;
//				leftCont1 = false;
//				rightCont1 = false;
//				downMode1 = false;
//				leftMode1 = false;
//				rightMode1 = false;
//			}
//			if ((action1) && (down)) {
//				Debug.Log ("Down1 and downcont1");
//				down1 = true;
//				left1 = false;
//				right1 = false;
//				up1 = false;
//				stop1 = false;
//				loop1 = false;
//				downMode1 = true;
//				downCont1 = true;
//				upCont1 = false;
//				leftCont1 = false;
//				rightCont1 = false;
//				upMode1 = false;
//				leftMode1 = false;
//				rightMode1 = false;
//			}
//			if ((action1) && (left)) {
//				Debug.Log ("Something went wrong 2");
//				left1 = true;
//				right1 = false;
//				up1 = false;
//				down1 = false;
//				stop1 = false;
//				loop1 = false;
//				leftMode1 = true;
//				leftCont1 = true;
//				upCont1 = false;
//				downCont1 = false;
//				rightCont1 = false;
//				upMode1 = false;
//				downMode1 = false;
//				rightMode1 = false;
//			}
//			if ((action1) && (right)) {
//				Debug.Log ("Something went wrong 3");
//				right1 = true;
//				left1 = false;
//				up1 = false;
//				down1 = false;
//				stop1 = false;
//				loop1 = false;
//				rightMode1 = true;
//				rightCont1 = true;
//				upCont1 = false;
//				downCont1 = false;
//				leftCont1 = false;
//				rightCont1 = true;
//				upMode1 = false;
//				downMode1 = false;
//				leftMode1 = false;
//			}
//			if ((action1) && (none)) {
//				Debug.Log ("Something went wrong 4");
//				left1 = false;
//				right1 = false;
//				up1 = false;
//				down1 = false;
//				loop1 = false;
//				stop1 = false;
//				upCont1 = false;
//				downCont1 = false;
//				leftCont1 = false;
//				rightCont1 = false;
//				upMode1 = false;
//				downMode1 = false;
//				leftMode1 = false;
//				rightMode1 = false;
//			}
//			if ((action1) && (stop)) {
//				Debug.Log ("Something went wrong 5");
//				up1 = false;
//				left1 = false;
//				right1 = false;
//				down1 = false;
//				loop1 = false;
//				stop1 = true;
//				upCont1 = false;
//				downCont1 = false;
//				leftCont1 = false;
//				rightCont1 = false;
//				upMode1 = false;
//				downMode1 = false;
//				leftMode1 = false;
//				rightMode1 = false;
//			}
//			if ((action1) && (loop)) {
//				Debug.Log ("Something went wrong 6");
//				up1 = false;
//				left1 = false;
//				right1 = false;
//				down1 = false;
//				loop1 = true;
//				stop1 = false;
//				upMode1 = false;
//				downMode1 = false;
//				leftMode1 = false;
//				rightMode1 = false;
//				upCont1 = false;
//				downCont1 = false;
//				leftCont1 = false;
//				rightCont1 = false;
//			}
//
//
//			if ((action2) && (up)) {
//				Debug.Log("Up2 and up2 cont");
//				up2 = true;
//				left2 = false;
//				right2 = false;
//				down2 = false;
//				stop2 = false;
//				loop2 = false;
//				upMode2 = true;
//				has2 = true;
//				upCont2 = true;
//				downCont2 = false;
//				leftCont2 = false;
//				rightCont2 = false;
//				downMode2 = false;
//				leftMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action2) && (down)) {
//				down2 = true;
//				left2 = false;
//				right2 = false;
//				up2 = false;
//				stop2 = false;
//				loop2 = false;
//				downMode2 = true;
//				has2 = true;
//				upCont2 = false;
//				downCont2 = true;
//				leftCont2 = false;
//				rightCont2 = false;
//				upMode2 = false;
//				leftMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action2) && (left)) {
//				left2 = true;
//				right2 = false;
//				up2 = false;
//				down2 = false;
//				stop2 = false;
//				loop2 = false;
//				leftMode2 = true;
//				has2 = true;
//				upCont2 = false;
//				downCont2 = false;
//				leftCont2 = true;
//				rightCont2 = false;
//				upMode2 = false;
//				downMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action2) && (right)) {
//				right2 = true;
//				left2 = false;
//				up2 = false;
//				down2 = false;
//				stop2 = false;
//				loop2 = false;
//				rightMode2 = true;
//				has2 = true;
//				upCont2 = false;
//				downCont2 = false;
//				leftCont2 = false;
//				rightCont2 = true;
//				upMode2 = false;
//				downMode2 = false;
//				leftMode2 = false;
//			}
//			if ((action2) && (none)) {
//				left2 = false;
//				right2 = false;
//				up2 = false;
//				down2 = false;
//				loop2 = false;
//				stop2 = false;
//				has2 = false;
//				upCont2 = false;
//				downCont2 = false;
//				leftCont2 = false;
//				rightCont2 = false;
//				upMode2 = false;
//				downMode2 = false;
//				leftMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action2) && (stop)) {
//				up2 = false;
//				left2 = false;
//				right2 = false;
//				down2 = false;
//				loop2 = false;
//				stop2 = true;
//				has2 = true;
//				upCont2 = false;
//				downCont2 = false;
//				leftCont2 = false;
//				rightCont2 = false;
//				upMode2 = false;
//				downMode2 = false;
//				leftMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action2) && (loop)) {
//				up2 = false;
//				left2 = false;
//				right2 = false;
//				down2 = false;
//				loop2 = true;
//				stop2 = false;
//				has2 = true;
//				upCont2 = false;
//				downCont2 = false;
//				leftCont2 = false;
//				rightCont2 = false;
//				upMode2 = false;
//				downMode2 = false;
//				leftMode2 = false;
//				rightMode2 = false;
//			}
//			if ((action3) && (up)) {
//				up3 = true;
//				left3 = false;
//				right3 = false;
//				down3 = false;
//				stop3 = false;
//				loop3 = false;
//				upMode3 = true;
//				has3 = true;
//				upCont3 = true;
//				downCont3 = false;
//				leftCont3 = false;
//				rightCont3 = false;
//				downMode3 = false;
//				leftMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action3) && (down)) {
//				down3 = true;
//				left3 = false;
//				right3 = false;
//				up3 = false;
//				stop3 = false;
//				loop3 = false;
//				downMode3 = true;
//				has3 = true;
//				upCont3 = false;
//				downCont3 = true;
//				leftCont3 = false;
//				rightCont3 = false;
//				upMode3 = false;
//				leftMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action3) && (left)) {
//				left3 = true;
//				right3 = false;
//				up3 = false;
//				down3 = false;
//				stop3 = false;
//				loop3 = false;
//				leftMode3 = true;
//				has3 = true;
//				upCont3 = false;
//				downCont3 = false;
//				leftCont3 = true;
//				rightCont3 = false;
//				upMode3 = false;
//				downMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action3) && (right)) {
//				right3 = true;
//				left3 = false;
//				up3 = false;
//				down3 = false;
//				stop3 = false;
//				loop3 = false;
//				rightMode3 = true;
//				has3 = true;
//				upCont3 = false;
//				downCont3 = false;
//				leftCont3 = false;
//				rightCont3 = true;
//				upMode3 = false;
//				downMode3 = false;
//				leftMode3 = false;
//			}
//			if ((action3) && (none)) {
//				left3 = false;
//				right3 = false;
//				up3 = false;
//				down3 = false;
//				loop3 = false;
//				stop3 = false;
//				has3 = false;
//				upCont3 = false;
//				downCont3 = false;
//				leftCont3 = false;
//				rightCont3 = false;
//				upMode3 = false;
//				downMode3 = false;
//				leftMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action3) && (stop)) {
//				up3 = false;
//				left3 = false;
//				right3 = false;
//				down3 = false;
//				loop3 = false;
//				stop3 = true;
//				has3 = true;
//				upCont3 = false;
//				downCont3 = false;
//				leftCont3 = false;
//				rightCont3 = false;
//				upMode3 = false;
//				downMode3 = false;
//				leftMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action3) && (loop)) {
//				up3 = false;
//				left3 = false;
//				right3 = false;
//				down3 = false;
//				loop3 = true;
//				stop3 = false;
//				has3 = true;
//				upCont3 = false;
//				downCont3 = false;
//				leftCont3 = false;
//				rightCont3 = false;
//				upMode3 = false;
//				downMode3 = false;
//				leftMode3 = false;
//				rightMode3 = false;
//			}
//			if ((action4) && (up)) {
//				up4 = true;
//				left4 = false;
//				right4 = false;
//				down4 = false;
//				stop4 = false;
//				loop4 = false;
//				upMode4 = true;
//				has4 = true;
//				upCont4 = true;
//				downCont4 = false;
//				leftCont4 = false;
//				rightCont4 = false;
//				downMode4 = false;
//				leftMode4 = false;
//				rightMode4 = false;
//			}
//			if ((action4) && (down)) {
//				down4 = true;
//				left4 = false;
//				right4 = false;
//				up4 = false;
//				stop4 = false;
//				loop4 = false;
//				downMode4 = true;
//				has4 = true;
//				upCont4 = false;
//				downCont4 = true;
//				leftCont4 = false;
//				rightCont4 = false;
//				upMode4 = false;
//				leftMode4 = false;
//				rightMode4 = false;
//			}
//			if ((action4) && (left)) {
//				left4 = true;
//				right4 = false;
//				up4 = false;
//				down4 = false;
//				stop4 = false;
//				loop4 = false;
//				leftMode4 = true;
//				has4 = true;
//				upCont4 = false;
//				downCont4 = false;
//				leftCont4 = true;
//				rightCont4 = false;
//				upMode4 = false;
//				downMode4 = false;
//				rightMode4 = false;
//			}
//			if ((action4) && (right)) {
//				right4 = true;
//				left4 = false;
//				up4 = false;
//				down4 = false;
//				stop4 = false;
//				loop4 = false;
//				rightMode4 = true;
//				has4 = true;
//				upCont4 = false;
//				downCont4 = false;
//				leftCont4 = false;
//				rightCont4 = true;
//				upMode4 = false;
//				downMode4 = false;
//				leftMode4 = false;
//			}
//			if ((action4) && (none)) {
//				left4 = false;
//				right4 = false;
//				up4 = false;
//				down4 = false;
//				loop4 = false;
//				stop4 = false;
//				has4 = false;
//				upCont4 = false;
//				downCont4 = false;
//				leftCont4 = false;
//				rightCont4 = false;
//				upMode4 = false;
//				downMode4 = false;
//				leftMode4 = false;
//				rightMode4 = false;
//			}
//			if ((action4) && (stop)) {
//				up4 = false;
//				left4 = false;
//				right4 = false;
//				down4 = false;
//				loop4 = false;
//				stop4 = true;
//				has4 = true;
//				upCont4 = false;
//				downCont4 = false;
//				leftCont4 = false;
//				rightCont4 = false;
//				upMode4 = false;
//				downMode4 = false;
//				leftMode4 = false;
//				rightMode4 = false;
//			}
//			if ((action4) && (loop)) {
//				up4 = false;
//				left4 = false;
//				right4 = false;
//				down4 = false;
//				loop4 = true;
//				stop4 = false;
//				has4 = true;
//				upCont4 = false;
//				downCont4 = false;
//				leftCont4 = false;
//				rightCont4 = false;
//				upMode4 = false;
//				downMode4 = false;
//				leftMode4 = false;
//				rightMode4 = false;
//			}
//
//		//}
//
//
//		if (Play) {
//			if (part1) {
//				ActionOne ();
//			
//
//			};
//			if ((timer <= 0) && (part1)) {
//				
//				part1 = false;
//				part2 = true;
//				timer = 50;
//			} else if (part2) {
//				ActionTwo ();
//
//
//			} if ((timer <= 0) && (part2)) {
//				timer = 50;
//				part2 = false;
//				part3 = true;
//			} else if (part3) {
//				ActionThree ();
//			} if ((timer <= 0) && (part3)) {
//				timer = 50;
//				part3 = false;
//				part4 = true;
//			} else if (part4) {
//				ActionFour ();
//
//			}if ((timer <= 0) && (part4)) {
//				timer = 50;
//				part4 = false;
//				part5 = true;
//			}
//		
//				else if (part5){
//				ActionFive ();
//						} timer--;
//		}
//}
//
//
//
//	void ActionOne(){
//		
//			if (stop1) {
//				Play = false;
//			}
//			if (loop1) {
//				part1 = true;
//				timer = 50;
//			}
//		if (part1) {
//			if ((up1) && (upMode1)) {
//				Vector4 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.1f);
//				this.transform.position = newPos;
//			}
//			if ((down1) && (downMode1)) {
//				Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.1f);
//				this.transform.position = newPos;
//			}
//			if ((left1) && (leftMode1)) {
//				Vector2 newPos = new Vector2 (this.transform.position.x - 0.1f, this.transform.position.y);
//				this.transform.position = newPos;
//			}
//			if ((right1) && (rightMode1)) {
//				Vector2 newPos = new Vector2 (this.transform.position.x + 0.1f, this.transform.position.y);
//				this.transform.position = newPos;
//			}
//		}
//	}
//
//	void ActionTwo(){
//
//		if (has2) {
//			if (stop2) {
//				Play = false;
//			}
//			if (loop2) {
//				part1 = true;
//				part2 = false;
//				timer = 50;
//			}
//			if (part2) {
//				if ((up2) && (upMode2)) {
//					Vector4 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((down2) && (downMode2)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((left2) && (leftMode2)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x - 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//				if ((right2) && (rightMode2)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x + 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//			}
//		}else{
//		ActionOne();
//	}
//	}
//	void ActionThree(){
//		if (has3) {
//			if (stop3) {
//				Play = false;
//			}
//			if (loop3) {
//				part1 = true;
//				part3 = false;
//				timer = 50;
//			}
//			if (part3) {
//
//				if ((up3) && (upMode3)) {
//					Vector4 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((down3) && (downMode3)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((left3) && (leftMode3)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x - 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//				if ((right3) && (rightMode3)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x + 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//			}
//		}else{
//			ActionTwo ();
//		}
//	}
//
//	void ActionFour(){
//		if (has4) {
//			if (stop4) {
//				Play = false;
//			}
//			if (loop4) {
//				part1 = true;
//				timer = 50;
//			}
//			if (part4) {
//
//				if ((up4) && (upMode4)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((down4) && (downMode4)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x, this.transform.position.y - 0.1f);
//					this.transform.position = newPos;
//				}
//				if ((left4) && (leftMode4)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x - 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//				if ((right4) && (rightMode4)) {
//					Vector2 newPos = new Vector2 (this.transform.position.x + 0.1f, this.transform.position.y);
//					this.transform.position = newPos;
//				}
//			}
//		} else{
//			ActionThree (); 
//	}
//	}
//
//	void ActionFive(){
//			ActionFour ();
//	}
//
//	void OnCollisionEnter2D(Collision2D col){
//
//		if (col.gameObject.tag == "Border") {
//			if (part1) {
//				if (upMode1) {
//					upMode1 = false;
//				}
//				if (downMode1) {
//					downMode1 = false;
//					Debug.Log("Hit border. Downmode1 false");
//				}
//				if (leftMode1) {
//					leftMode1 = false;
//				}
//				if (rightMode1) {
//					rightMode1 = false;
//				}
//			}
//			if (part2) {
//
//				if (upMode2) {
//					upMode2 = false;
//				}
//				if (downMode2) {
//					downMode2 = false;
//				}
//				if (leftMode2) {
//					leftMode2 = false;
//				}
//				if (rightMode2) {
//					rightMode2 = false;
//				}
//			}
//			if (part3) {
//
//				if (upMode3) {
//					upMode3 = false;
//				}
//				if (downMode3) {
//					downMode3 = false;
//				}
//				if (leftMode3) {
//					leftMode3 = false;
//				}
//				if (rightMode3) {
//					rightMode3 = false;
//				}
//			}
//			if (part4) {
//
//				if (upMode4) {
//					upMode4 = false;
//				}
//				if (downMode4) {
//					downMode4 = false;
//				}
//				if (leftMode4) {
//					leftMode4 = false;
//				}
//				if (rightMode4) {
//					rightMode4 = false;
//				}
//			}
//		}
//
//	}
//
//	void ResetLift(){
//		Play = false;
//		none = false;
//		action1 = false;
//		action2 = false;
//		action3 = false;
//		action4 = false;
//		up = false;
//		down = false;
//		left = false;
//		right = false;
//		stop = false;
//		loop = false;
//		int timer = 50;
//
//		GameObject newLift = Instantiate (Lift);
//		GameObject.Find ("TheCanvas").GetComponent<ButtonPressed> ().lif = newLift.GetComponent<NewLiftScript> ();
//		Vector2 newPos = new Vector2 (3.43f, -3f);
//		newLift.transform.position = newPos;
//		if (upCont1) {
//			upMode1 = true;
//			Debug.Log ("Should be off");
//	
//		}
//		if (downCont1) {
//			downMode1 = true;
//			Debug.Log ("Downmode1 true. Downmode cont1 triggered");
//		}
//		if (leftCont1) {
//			leftMode1 = true;
//		}
//		if (rightCont1) {
//			rightMode1 = true;
//		}
//		if (upCont2) {
//			upMode2 = true;
//		
//		}
//		if (downCont2) {
//			downMode2 = true;
//		}
//		if (leftCont2) {
//			leftMode2 = true;
//		}
//		if (rightCont2) {
//			rightMode2 = true;
//		}
//		if (upCont3) {
//			upMode3 = true;
//		}
//		if (downCont3) {
//			downMode3 = true;
//		}
//		if (leftCont3) {
//			leftMode3 = true;
//		}
//		if (rightCont3) {
//			rightMode3 = true;
//		}
//		if (upCont4) {
//			upMode4 = true;
//		}
//		if (downCont4) {
//			downMode4 = true;
//		}
//		if (leftCont4) {
//			leftMode4 = true;
//		}
//		if (rightCont4) {
//			rightMode4 = true;
//		}
//	Destroy(gameObject);
//	}
//}
//
