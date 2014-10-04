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
		if(Input.GetAxis("Horizontal") < 0)
			transform.localScale.Set(-1,1,1);
		else
			transform.localScale.Set(1,1,1);
	}
}
