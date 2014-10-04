using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	public int lives = 3;
	public float invincible_time = 3f;
	public Transform spawn;
	float invuln = 0f; // time left of invincibility
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Hit() {
		if(invuln > 0)
			return;
		// animate death and particles

		// lose life & respawn, or gameover
		if(lives-- < 0)
			Application.LoadLevel("MainMenu");
		else
			Respawn();
	}
	void Respawn() {
		transform.position = spawn.position;
		invuln = invincible_time;
		StartCoroutine("Invulnerable");
	}

	IEnumerator Invulnerable() {
		while (invuln > 0) {
			invuln -= Time.deltaTime;
			// animate invinc flash

			yield return null;
		}
	}
}
