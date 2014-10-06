using UnityEngine;
using System.Collections;

public class VacuumShot : MonoBehaviour {
	public GameObject bullet;
	private Transform shotCatcher;
	private GameObject[] bullets;
	int shotFrames;
	int offset = 0;
	// Use this for initialization
	void Start () {
		shotFrames = 25;
		bullets = new GameObject[8];
	}
	
	// Update is called once per frame
	void Update () {
		if(shotFrames == 0){
			shotFrames = 25;
			for(int i = 0; i < 8; i++)
			{
				bullets[i] = (GameObject)Instantiate (bullet, this.transform.position, transform.rotation);
				bullets[i].transform.Rotate (Vector3.forward*(45*i + offset));
				bullets[i].transform.parent=shotCatcher;
			}
			offset+=5;
		}
		else{
			shotFrames--;
		}
	}
}
