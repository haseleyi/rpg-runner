﻿// <copyright file="MainMenu.cs" company="DIS Copenhagen">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Benno Lueders</author>
// <date>14/08/2017</date>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main menu script. Provides functionality to start and quit the game controlled by buttons from the Unity UI.
/// </summary>
public class MainMenu : MonoBehaviour {

	void Start() {
		GameManager.gameState = GameManager.GameState.MainMenu;
	}

	public void StartGame() {
		StartCoroutine (GameStartCoroutine());
	}

	IEnumerator GameStartCoroutine() {
		SoundManager.instance.swordClash.Play ();
		yield return new WaitForSeconds (1);
		GameManager.gameState = GameManager.GameState.Running;
		GameManager.instance.LoadScene ("Game");
	}
}
