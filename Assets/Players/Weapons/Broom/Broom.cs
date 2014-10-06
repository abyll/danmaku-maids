using UnityEngine;
using System.Collections;

// Broom shoots a spray of straw shots. 
public class Broom : Weapon {
	public GameObject shot;
	public float firerate = 0.2f; // Time in seconds between shots
	public Sprite icon;
	private float nextShot = 0;
	private Transform shotContainer;

	public void Start() {
		shotContainer = GameObject.Find("Shots").transform;
	}

	public override void Fire() {
		if(nextShot < Time.time) {
			nextShot = Time.time + firerate;
			// Spawn 3 straws in wedge formation

			GameObject leftshot = (GameObject)Instantiate(shot, transform.position, transform.rotation);
			leftshot.transform.position += transform.up * -0.2f + transform.right * -0.2f;
			GameObject rightshot = (GameObject)Instantiate(shot, transform.position, transform.rotation);
			rightshot.transform.position += transform.up * -0.2f + transform.right * 0.2f;
			GameObject foreshot = (GameObject)Instantiate(shot, transform.position, transform.rotation);
			leftshot.transform.parent = shotContainer;
			rightshot.transform.parent = shotContainer;
			foreshot.transform.parent = shotContainer;
		} else {

		}
	}
}
