using UnityEngine;
using System.Collections;

public class Roomba : MonoBehaviour {
	Animator anim;
	GameObject chase;
	public float speed = .03f;
	public int frameMod = 1;
	float numFrames = 0;
	float myAngle = 90f;
	Vector2 Vel;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
		chase = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(numFrames <= 0){
			if(Mathf.Abs (getAngle ()-myAngle) <= 15){
				SetChase ();
				myAngle = getAngle ();
			}
			else
			{
				myAngle = ((myAngle+frameMod)%360);
			}
		}
		else
		{
			this.transform.Translate(Vel);
		}
		//Debug.Log ("My Angle: " + myAngle + ", target angle: " + getAngle () + ", frames remaining: " + numFrames);
		numFrames--;
		setAnim ();
	}

	void SetChase(){
		float dist = GetDistToPlayer();
		numFrames = dist/speed; //Number of frames to reach destination; .03 is the speed.
		Vector2 tempVel = trackDist ();
		tempVel.x = (tempVel.x/numFrames);
		tempVel.y = (tempVel.y/numFrames);
		Vel.x = tempVel.x;
		Vel.y = tempVel.y;
	}	
	float GetDistToPlayer(){
		Vector2 Dist = trackDist ();
		float distance = Mathf.Sqrt ((Dist.x*Dist.x)+(Dist.y*Dist.y));
		return distance;
	}	
	Vector2 trackDist(){
		return new Vector2(chase.transform.position.x-this.transform.position.x, chase.transform.position.y-this.transform.position.y);
	}

	float getAngle(){
		var heading = chase.transform.position - this.transform.position;
		var direction = heading / heading.magnitude;
		float angulardir = Vector3.Angle (direction, new Vector3(-1, 0, 0));
		if(chase.transform.position.y < this.transform.position.y && (angulardir%180) != 0){
			angulardir = 360-angulardir;
		}
		return angulardir;
	}

	void setAnim(){
		if(myAngle < 45){
			anim.SetInteger ("Direction", 1);
		}
		else if(myAngle < 135){
			anim.SetInteger ("Direction", 2);
		}
		else if(myAngle < 225){
			anim.SetInteger ("Direction", 3);
		}
		else if(myAngle < 315){
			anim.SetInteger ("Direction", 0);
		}
		else{
			anim.SetInteger ("Direction", 1);
		}
	}
}
