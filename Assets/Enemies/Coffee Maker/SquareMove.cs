using UnityEngine;
using System.Collections;

public class SquareMove : MonoBehaviour {

	public int tick;
	public float baseVal = 120; //Number of frames before the square loops.  Must ALWAYS be divisible by four.
	public float baseDist = 1; //Distance in unity units to move
	float speed;
	float yV;
	float xV;
	Animator anim;
	// Use this for initialization
	void Start () {
		speed = (baseDist/(baseVal/4));
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(tick == 0)
		{
			yV = 0.0f;
			xV = speed;
			anim.SetInteger ("Direction", 3); //3 is RIGHT or EAST depending.
		}
		if(tick == (baseVal/4))
		{
			yV = speed;
			xV = 0.0f;
			anim.SetInteger ("Direction", 2); //2 is UP or NORTH depending.
		}
		if(tick == (baseVal/2))
		{
			xV = -speed;
			yV = 0.0f;
			anim.SetInteger ("Direction", 1); //1 is LEFT or WEST depending.
		}
		if(tick == (3*baseVal/4))
		{
			xV = 0.0f;
			yV = -speed;
			anim.SetInteger ("Direction", 0); //0 is DOWN or SOUTH depending.
		}
		if(tick == baseVal)
		{
			xV = speed;
			yV = 0.0f;
			tick = -1;
			anim.SetInteger ("Direction", 3); //3 is RIGHT or EAST depending.
		}
		transform.Translate (xV, yV, 0);

		tick++;
	}
}
