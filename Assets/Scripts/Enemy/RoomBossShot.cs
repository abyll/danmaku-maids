using UnityEngine;
using System.Collections;

public class RoomBossShot : MonoBehaviour {
	public GameObject bullet;
	private Transform bulletCatcher;
	private GameObject[] bullets;
	int offset;
	int shotframes;
	// Use this for initialization
	void Start () {
		shotframes = 3;
		offset = 0;
		bullets = new GameObject[4];
	}
	
	// Update is called once per frame
	void Update () {
		if(shotframes == 0){
			shotframes = 6;
			for(int i = 0; i < 4; i++)
			{
				bullets[i] = (GameObject)Instantiate (bullet, this.transform.position, transform.rotation);
				bullets[i].transform.Rotate (Vector3.forward*((360/4)*i + offset));
				bullets[i].transform.parent=bulletCatcher;
			}
			offset++;
		}
		else{
			shotframes--;
		}
	}
}
