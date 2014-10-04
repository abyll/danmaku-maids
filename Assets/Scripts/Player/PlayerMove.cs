using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Vertical")*speed, 0);   
		var pos = Camera.main.WorldToViewportPoint(transform.position);
		pos.x = Mathf.Clamp(pos.x, 0,1);
		pos.y = Mathf.Clamp(pos.y, 0,1);
		transform.position = Camera.main.ViewportToWorldPoint(pos);
		if(Input.GetAxis("Horizontal") < 0)
			transform.localScale.Set(-1,1,1);
		else
			transform.localScale.Set(1,1,1);
	}
}
