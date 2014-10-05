using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {
	public GameObject enemy1;
	public GameObject svacuum1;
	public GameObject svacuum2;
	public GameObject llamp;
	public GameObject rlamp;
	public GameObject boss;
	// Use this for initialization
	void Start () {
		StartCoroutine (CauseRoomba ());
		StartCoroutine (CauseVacuum ());
		StartCoroutine (AddLamps ());
		StartCoroutine (BossFight());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator BossFight(){
		yield return new WaitForSeconds(90);
		makeNewEnemy (boss, 0, 4);
	}

	IEnumerator CauseRoomba(){
		yield return new WaitForSeconds(4);
		for(int i = 0; i < 27; i++)
		{
			yield return new WaitForSeconds(3);//Wait three seconds after the level starts.  Only fair.
			switch(Random.Range (1,4)){
			case 1:
				makeNewEnemy (enemy1, 0, 4f); //'Main door'...
				break;
			case 2:
				makeNewEnemy (enemy1, 6.5f, Random.Range (-2, 2)); //Right hall...
				break;
			case 3:
				makeNewEnemy (enemy1, -6.5f, Random.Range (-2, 2)); //and Left hall.
				break;
			}
		}
	}
	IEnumerator CauseVacuum(){
		for(int i = 0; i < 8; i++){
			yield return new WaitForSeconds(5);
			makeNewEnemy (svacuum1, -6.5f, -3f);
			makeNewEnemy (svacuum2, 6.5f, 1f);
			yield return new WaitForSeconds(5);
			makeNewEnemy (svacuum1, -6.5f, 1f);
			makeNewEnemy (svacuum2, -6.5f, -1f);
		}
	}
	IEnumerator AddLamps(){
		yield return new WaitForSeconds(10);
		makeNewEnemy (rlamp, 6.5f, 1.5f);
		makeNewEnemy (llamp, -6.5f, 1.5f);
		makeNewEnemy (rlamp, 6.5f, -3f);
		makeNewEnemy (llamp, -6.5f, -3f);
		yield return new WaitForSeconds(45);
		makeNewEnemy (rlamp, 6.5f, 1.5f);
		makeNewEnemy (llamp, -6.5f, 1.5f);
		makeNewEnemy (rlamp, 6.5f, -3f);
		makeNewEnemy (llamp, -6.5f, -3f);
		yield return new WaitForSeconds(80);
		makeNewEnemy (rlamp, 6.5f, 1.5f);
		makeNewEnemy (llamp, -6.5f, 1.5f);
		makeNewEnemy (rlamp, 6.5f, -3f);
		makeNewEnemy (llamp, -6.5f, -3f);
	}
	
	void makeNewEnemy(GameObject type, float x, float y){
		/*GameObject temp = (GameObject)*/Instantiate (type.transform, new Vector3(x, y, 0), type.transform.rotation);
		Debug.Log("Made an enemy at "+x+","+y+"!");
	}
//	void makeNewVacuum(GameObject type, float x, float y, float xT, float yT, float RAdj, int SetDeg, float diam){
//		/*GameObject temp = (GameObject)*/Instantiate (type.transform, new Vector3(x, y, 0), type.transform.rotation);
		/*temp.GetComponent<VacuumCleaner>().xTrans = xT;
		temp.GetComponent<VacuumCleaner>().yTrans = yT;
		temp.GetComponent<VacuumCleaner>().radadjust = RAdj;
		temp.GetComponent<VacuumCleaner>().present = SetDeg;
		temp.GetComponent<VacuumCleaner>().diameter = diam;*/
//		Debug.Log ("Made a vacuum!");
//	}
}

