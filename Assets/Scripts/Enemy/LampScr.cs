using UnityEngine;
using System.Collections;

public class LampScr : MonoBehaviour {
	public float dist = 1.5f;
	public int time = 30;
	float mySpeed = 0;
	// Use this for initialization
	void Start () {
		mySpeed = dist/time;
	}
	
	// Update is called once per frame
	void Update () {
		if(time > 0){
			time--;
			this.transform.Translate (mySpeed, 0, 0);
		}
		else{
			//Nope.
		}
	}
}
