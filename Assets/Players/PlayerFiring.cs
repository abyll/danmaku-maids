using UnityEngine;
using System.Collections;

public class PlayerFiring : MonoBehaviour {
	public Transform weaponHolder;
	public GameObject[] weapons;
	private Weapon selectedweapon = null;
	private int selectedIndex = 0;
	private GameObject WeaponHUD;
	// Use this for initialization
	void Start () {
		WeaponHUD = GameObject.FindGameObjectWithTag("WeaponHUD");
		for(int i=0; i<weapons.Length; ++i) {
			GameObject wpn = (GameObject)Instantiate(weapons[i], weaponHolder.position, weaponHolder.rotation);
			wpn.SetActive(false);
			wpn.transform.parent = weaponHolder;
			weapons[i] = wpn;
			//WeaponHUD

		}
		selectedweapon = weapons[selectedIndex].GetComponent<Weapon>();
		selectedweapon.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Weapon1")) {
			SwitchWeapon(0);
		} else if (Input.GetButtonDown("Weapon2")) {
			SwitchWeapon(1);
		}
		// Aim the weapon's parent
		var pos = new Vector3(Input.GetAxis("HorizontalAim"), Input.GetAxis("VerticalAim"), 0.0f);
		if(pos.sqrMagnitude > 0) {
			weaponHolder.up = pos;
			//transform.FindChild("Weapon").transform.position += transform.FindChild("Weapon").right * 0.01f;
			selectedweapon.Fire();
		}
	}

	void SwitchWeapon(int wpn) {
		// Only switch if it'll change weapons, then change Active for them
		Debug.Log("Switched to" + wpn.ToString());
		if(wpn < weapons.Length && wpn != selectedIndex) {
			selectedweapon.gameObject.SetActive(false);
			selectedweapon = weapons[wpn].GetComponent<Weapon>();
			selectedweapon.gameObject.SetActive(true);
			Debug.Log(selectedweapon.gameObject);
			selectedIndex = wpn;
		}
	}
}
