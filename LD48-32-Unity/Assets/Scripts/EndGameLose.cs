﻿using UnityEngine;
using System.Collections;

public class EndGameLose : MonoBehaviour {

	private GUIStyle labelStyle;
	private float canClickTime;
	// Use this for initialization
	void Start () {
		canClickTime = Time.time + 2f;
	}
	
	// Update is called once per frame
	void Update () {
		labelStyle = new GUIStyle ();
		labelStyle.fontSize = 20;
		labelStyle.fontStyle = FontStyle.Bold;
		labelStyle.alignment = TextAnchor.MiddleCenter;

		if(Input.GetMouseButtonDown(0) && Time.time>canClickTime){
			Application.LoadLevel("Game");
		}
	}

	void OnGUI(){
		GUI.color = Color.white;
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),"YOU LOST\nYou couldn't eliminate "+Printer.maxKillCount+" people\nThanks for playing\nCLICK TO RESTART\nFind us at\nsuperdamage.com",labelStyle);
	
	}

}
