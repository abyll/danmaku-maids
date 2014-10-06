using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int health = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Hit(){
		health--;
		if(health == 0){
			Destroy (gameObject);
		}
	}
}
