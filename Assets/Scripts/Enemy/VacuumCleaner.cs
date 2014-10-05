using UnityEngine;
using System.Collections;

public class VacuumCleaner : MonoBehaviour {
	Animator anim;
	public float xTrans = .005f;
	public float yTrans = 0;
	public float radadjust = 0;
	public int present = 0; 
	int angle;
	public float diameter = 1f;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Mathf.Sin (present*Mathf.Deg2Rad)*diameter/100, Mathf.Cos (present*Mathf.Deg2Rad)*diameter/100, 0f);
		this.transform.Translate (xTrans, yTrans, 0);
		diameter+=radadjust;
		present++;
		//Pos.x+=xTrans;
		//Debug.Log (transform.position.x + "," + transform.position.y + ", RAdj:" + radadjust);
		angle = present%360;
		if(angle < 45 || angle > 315){
			anim.SetInteger ("Direction", 2);
		}
		if(angle >= 45 && angle <= 135){
			anim.SetInteger ("Direction", 3);
		}
		if(angle > 135 && angle < 215){
			anim.SetInteger ("Direction", 0);
		}
		if(angle >= 215 && angle <= 315){
			anim.SetInteger ("Direction", 1);
		}
	}
	void SetData(){
		//this.transform.position.Set(
	}
}
