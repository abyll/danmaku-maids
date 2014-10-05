using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {
	public GameObject enemy1;
	// Use this for initialization
	void Start () {
		StartCoroutine (Flyby ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Flyby(){
		yield return new WaitForSeconds(3);//Wait three seconds after the level starts.  Only fair.
		makeNewEnemy (enemy1, 0, 2.5f);
	}
	
	void makeNewEnemy(GameObject type, float x, float y){
		/*GameObject temp = (GameObject)*/Instantiate (type.transform, new Vector3(x, y, 0), type.transform.rotation);
		Debug.Log("Made an enemy at "+x+","+y+"!");
	}
}

