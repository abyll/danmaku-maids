using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour {
	private Weapon weapon;
	// Use this for initialization
	void Start () {
		weapon = GetComponentInChildren<Weapon>();

	}
	
	// Update is called once per frame
	void Update () {
		var pos = new Vector3(Input.GetAxis("HorizontalAim"), Input.GetAxis("VerticalAim"), 0.0f);
		if(pos.sqrMagnitude > 0) {
			transform.FindChild("Weapon").up = pos;
			//transform.FindChild("Weapon").transform.position += transform.FindChild("Weapon").right * 0.01f;
			weapon.Fire();
		}
	}
}
