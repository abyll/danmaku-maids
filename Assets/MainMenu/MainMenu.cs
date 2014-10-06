using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject[] characters;
	private enum MenuScreen { Main, CharacterSelect };
	
	private MenuScreen currentMenu = MenuScreen.Main;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
//		// Button dimension
//		var buttonWidth = 300;
//		var buttonHeight = 50;
//		
//		// Button positioning
//		var horizontalOffset = buttonWidth / 2;
		GUILayout.BeginArea ( new Rect ( Screen.width / 4, Screen.height / 2, Screen.width / 2, Screen.height / 2 ) );
		GUILayout.BeginVertical ();
		switch (currentMenu)
		{
		case(MenuScreen.Main) :
			if( GUILayout.Button("Start") )
				currentMenu = MenuScreen.CharacterSelect;
			if( GUILayout.Button ( "Exit" ) )
				Application.Quit ();
			break;
		case MenuScreen.CharacterSelect:
			if( GUILayout.Button("Suzuka"))
				LoadCharacter(0);
			if( GUILayout.Button("Hotaru"))
				LoadCharacter(1);
			if (GUILayout.Button("Back"))
				currentMenu = MenuScreen.Main;
			break;
		}
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}

	void LoadCharacter(int character) {
		GameObject chr = (GameObject)Instantiate(characters[character]);
		Object.DontDestroyOnLoad(chr);
		Application.LoadLevel("test");
	}
}
