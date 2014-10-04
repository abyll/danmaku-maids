using UnityEngine;
using System.Collections;

public class DefaultShot : MonoBehaviour {
	enum ShotType {Water, Fire, Gunk, Dirt, Electric, None};

	ShotType type = ShotType.None;
	// Use this for initialization
	void Start () {
		int layer=15; // Unity's UserLayers
		switch(type) {
		case ShotType.Dirt:
			layer = 12;
			break;
		case ShotType.Electric:
			layer = 14;
			break;
		case ShotType.Fire:
			layer = 11;
			break;
		case ShotType.Gunk:
			layer = 13;
			break;
		case ShotType.Water:
			layer = 10;
			break;
		}
		gameObject.layer = layer;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
