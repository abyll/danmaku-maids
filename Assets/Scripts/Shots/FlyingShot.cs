using UnityEngine;
using System.Collections;

public class FlyingShot : MonoBehaviour {
	
	public float speed = 0.1f;
	void Start () {
		Destroy(gameObject, 5.0f);
	}

	void Update () {
		// Basic movement example. This is/should be replaced by proper movement scripts
		transform.Translate (0,speed,0);
	
	}
}
