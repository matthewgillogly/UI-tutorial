﻿using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public Menu CurrentMenu;
	void Start () {
		if(CurrentMenu != null)
			ShowMenu (CurrentMenu);
	}
	public void ShowMenu(Menu menu)
	{
		if (CurrentMenu != null)
			CurrentMenu.IsOpen = false;
		
		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;
	}
}
