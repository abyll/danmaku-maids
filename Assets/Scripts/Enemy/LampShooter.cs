using UnityEngine;
using System.Collections;

public class LampShooter : MonoBehaviour {
	public GameObject bullet;
	public float angle = 45;
	float Angle;
	int shottimer = 45;
	//int pattern = 1;  Was gonna go 3-5-3-5 but screw it
	// Use this for initialization
	private Transform shotCatcher;
	void Start () {
		Angle = angle;
	}
	
	// Update is called once per frame
	void Update () {
		if(shottimer == 0){
			shottimer = 45;
			GameObject bul1 = (GameObject)Instantiate (bullet, transform.position, transform.rotation);
			bul1.transform.Rotate (Vector3.forward*(-Angle));
			bul1.transform.parent = shotCatcher;
			GameObject bul2 = (GameObject)Instantiate (bullet, transform.position, transform.rotation);
			bul2.transform.Rotate (Vector3.forward*(15-Angle));
			bul2.transform.parent = shotCatcher;
			GameObject bul3 = (GameObject)Instantiate (bullet, transform.position, transform.rotation);
			bul3.transform.Rotate (Vector3.forward*(-15-Angle));
			bul3.transform.parent = shotCatcher;
		}
		else{
			shottimer--;
		}
	}
}
