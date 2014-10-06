using UnityEngine;
using System.Collections;

public class Vacuum: Weapon {
	public GameObject shot;
	public float tick_rate = 0.25f;
	public float live_rate = 0.14f;
	public Sprite icon;
	private float next_shot = 0;
	// Use this for initialization
	void Start () {
		shot = (GameObject)Instantiate(shot, transform.position, transform.rotation);
		shot.transform.parent = transform;
		shot.transform.position += transform.up * 0.2f;
	}
	
	// Update is called once per frame

	public override void Fire()
	{
		if(Time.time > next_shot) {
			next_shot = Time.time + tick_rate;
			shot.SetActive(true);
			Invoke("Hide", live_rate);
		}
	}

	void Hide() {
		shot.SetActive(false);
	}
}
