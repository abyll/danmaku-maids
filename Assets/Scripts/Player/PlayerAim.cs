using UnityEngine;
using System.Collections;

public class PlayerAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var pos = new Vector3(Input.GetAxis("HorizontalAim"), Input.GetAxis("VerticalAim"), 0.0f);
		transform.GetChild(0).localPosition = pos;
		Debug.Log (pos);
	}
}
