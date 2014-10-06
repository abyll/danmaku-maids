using UnityEngine;
using System.Collections;

public class WeaponIcons : MonoBehaviour {
	public Sprite[] activeIcons;
	public Sprite[] inactiveIcons;
	private SpriteRenderer[] icons;
	public int current=0;
	// Use this for initialization
	void Start () {
		icons = new SpriteRenderer[activeIcons.Length];
		for(int i=0; i<icons.Length; ++i) {
			var obj = new GameObject();
			obj.transform.parent = transform;
			obj.transform.position = transform.position;
			var sprite_render = obj.AddComponent<SpriteRenderer>();
			icons[i] = sprite_render;
			sprite_render.sprite = inactiveIcons[i];
			obj.transform.Translate(i * inactiveIcons[i].bounds.size.x, 0, 0);
		}
		Active(current);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Active(int index) {
		icons[current].sprite = inactiveIcons[current];
		icons[index].sprite = activeIcons[index];
		current = index;
	}
}
