﻿using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() 
	{
		Speech.AddDialogue("0", "Welcome to our planet!", "1");
		Speech.AddDialogue("1", "You have to collect all coins!", "2");
		Speech.AddDialogue("2", "Find Powerup", "3");
		Speech.AddDialogue("3", "Then find a way to the next island");




	}
	
	

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other )
	{
		Speech.SetDialogue("0");
	}
}