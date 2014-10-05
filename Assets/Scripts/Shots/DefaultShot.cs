using UnityEngine;
using System;
using System.Collections;

public class DefaultShot : MonoBehaviour {
	public enum ShotType {Gunk,Dirt,Metal, None};
	public bool player = false;
	public ShotType type = ShotType.None;
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		int layer=14; // Unity's UserLayers
		switch (type) {
		case ShotType.Gunk:
			layer = 11;
			break;
		case ShotType.Dirt:
			layer = 12;
			break;
		case ShotType.Metal:
			layer = 13;
			break;
		}
		gameObject.layer = layer;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,speed,0);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (player && col.gameObject.CompareTag("Player"))
			return;
		col.gameObject.SendMessage("Hit");
		Destroy(gameObject);
	}
	void Hit() {
		Destroy(gameObject);
	}
}
