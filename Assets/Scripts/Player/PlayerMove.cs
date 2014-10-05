using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float normalspeed = 0.05f;
	public float focusspeed = 0.02f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed;
		// Slow on focus, and add the hitbox sprite
		if(Input.GetButton("Focus"))
			speed = focusspeed;
		else {
			speed = normalspeed;
		}
		transform.Translate(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed, 0);   
		// Clamp within screen area
		var pos = Camera.main.WorldToViewportPoint(transform.position);
		pos.x = Mathf.Clamp(pos.x, 0,1);
		pos.y = Mathf.Clamp(pos.y, 0,1);
		transform.position = Camera.main.ViewportToWorldPoint(pos);

		// Animation swiching
		//TODO: Move this to aim controls, rather than move?
		if(Input.GetAxis("Horizontal") < 0)
			transform.localScale.Set(-1,1,1);
		else
			transform.localScale.Set(1,1,1);
	}
}
