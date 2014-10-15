﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private enum Menu { MAIN, SETTINGS, LOAD };
	private static Menu scene = Menu.MAIN;

	private Texture2D new_game;
	private Texture2D load_game;
	private Texture2D settings;
	private Texture2D quit;

	public void Start() {

		new_game = Resources.Load ("Artwork/Main_Menu/new_game") as Texture2D;
		load_game = Resources.Load ("Artwork/Main_Menu/load_game") as Texture2D;
		settings = Resources.Load ("Artwork/Main_Menu/settings") as Texture2D;
		quit = Resources.Load ("Artwork/Main_Menu/quit") as Texture2D;

	}

	public void OnGUI()
	{
		if(scene == Menu.MAIN) 
		{
			if (GUI.Button (new Rect ((Screen.width)/5+15, (Screen.height)/2+15, 100, 50), new_game, ""))
			{
				Application.LoadLevel ("TileMapTester");
			}
			if (GUI.Button (new Rect ((Screen.width)/5+15, (Screen.height)/2+65, 100, 50), load_game, ""))
			{
				Application.LoadLevel ("TileMapTester");
			}
			if (GUI.Button (new Rect ((Screen.width)/5+15, (Screen.height)/2+115, 100, 50), settings, ""))
			{
				scene = Menu.SETTINGS;
			}
			if (GUI.Button (new Rect (Screen.width-125, Screen.height-Screen.height/8-15, 75, 30), quit, ""))
			{
				Application.Quit ();
			}

		} else if(scene == Menu.SETTINGS)
		{
			GUI.HorizontalSlider (new Rect ((Screen.width)/5+15, (Screen.height)/2+20, 100, 50), 10, 0, 20);
			GUI.Label (new Rect ((Screen.width)/5+10, (Screen.height)/2+45, 200, 100), "MASTER VOLUME");
			if (GUI.Button (new Rect ((Screen.width)/5+15, (Screen.height)/2+80, 100, 50), "BACK"))
			{
				scene = Menu.MAIN;
			}
			if (GUI.Button (new Rect (Screen.width-125, Screen.height-Screen.height/8-15, 75, 30), quit, ""))
			{
				Application.Quit ();
			}
		}

	}
}