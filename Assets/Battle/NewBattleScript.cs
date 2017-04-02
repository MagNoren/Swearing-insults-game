using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading;

using UnityEngine;
using UnityEngine.UI;

public class NewBattleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		getInsults();
	}

	// Update is called once per frame
	void Update () {
		mainLoop();
	}

	public List<string> insults;
	public List<int> insultPowers;

	bool gamePause = false;
	bool optionSelected = false;

	public int wins;
	public int losses;

	/// <summary>
	/// Gets the insults.
	/// </summary>
	/// HOLY FUCK YES IT WORKS 6/1/2017
	void getInsults() 
	{
		//For public sake
		print((Resources.Load("vulgarInsults", typeof(TextAsset)) as TextAsset).text);
		List<string> lines = new List<string>((Resources.Load("vulgarInsults", typeof(TextAsset)) as TextAsset).text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None));
		//Defaults to clean
		if (PlayerPrefs.GetString("SwearingAllowed") == "true")
		{
			//Can swear
			lines = new List<string>((Resources.Load("vulgarInsults", typeof(TextAsset)) as TextAsset).text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None));
		}
		else
		{
			//Can't swear
			lines = new List<string>((Resources.Load("vulgarInsults", typeof(TextAsset)) as TextAsset).text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None));
		}

		foreach (var line in lines) 
		{
			//print (line);
			int index = lines.IndexOf(line);

			if (index % 2 == 0)
			{
				//Is even: Add it to insults
				insults.Add(line);
			}
			else
			{
				//Is odd: Remove, add to insultPowers
				insultPowers.Add(Int32.Parse(line));
			}
		}

		//print ("Insults");
		//print (insults.Count);
		//print ("Powers");
		//print (insultPowers.Count);

	}

	//The button texts
	public Text playerButtonOneText;
	public Text playerButtonTwoText;
	public Text playerButtonThreeText;

	public Text botInsultText;

	//The player powers
	int insultOnePlayerPower;
	int insultTwoPlayerPower;
	int insultThreePlayerPower;

	int botInsultPower;

	int totalPlayerPower;

	System.Random rnd = new System.Random();

	List<int> usedNumbers = new List<int>();

	void pickInsults()
	{
		//Run this whilst the game isn't paused
		if (!gamePause)
		{
			//Start
			int insultIndex;

			//First number
			insultIndex = rnd.Next(0, insults.Count - 1);
			usedNumbers.Add(insultIndex);
			playerButtonOneText.text = insults[insultIndex];
			insultOnePlayerPower = insultPowers[insultIndex];

			while (true)
			{
				insultIndex = rnd.Next(0, insults.Count - 1);
				//Checks the number hasn't been used
				if (usedNumbers.Contains (insultIndex)) {
					continue;
				}
				else 
				{
					usedNumbers.Add(insultIndex);
					playerButtonTwoText.text = insults[insultIndex];
					insultTwoPlayerPower = insultPowers[insultIndex];
					break;
				}

			}

			while (true)
			{
				insultIndex = rnd.Next(0, insults.Count - 1);
				//Checks the number hasn't been used
				if (usedNumbers.Contains (insultIndex)) {
					continue;
				}
				else 
				{
					usedNumbers.Add(insultIndex);
					playerButtonThreeText.text = insults[insultIndex];
					insultThreePlayerPower = insultPowers[insultIndex];
					break;
				}

			}

			//Make the bot insult power and that
			while (true)
			{
				insultIndex = rnd.Next(0, insults.Count - 1);
				//Checks the number hasn't been used
				if (usedNumbers.Contains (insultIndex)) {
					continue;
				}
				else 
				{
					usedNumbers.Add(insultIndex);
					botInsultText.text = insults[insultIndex];
					botInsultPower = insultPowers [insultIndex] * rnd.Next (0, 4);
					break;
				}
			}

			//Resets the used numbers list
			usedNumbers = new List<int>();
		}
		//After loading the insults, the game pauses so we can get an answer
		gamePause = true;
	}

	public Text winText;
	public Text lossText;

	void mainLoop()
	{
		if (gamePause == false)
		{
			//npcInsult();
			pickInsults();
		}

		if (optionSelected == true) 
		{
			if (totalPlayerPower > botInsultPower)
			{
				wins += 1;
				print ("win");
				print (wins);
				winText.text = wins.ToString();
			}
			else if (totalPlayerPower < botInsultPower)
			{
				losses += 1;
				print("lose");
				print(losses);
				lossText.text = losses.ToString();
			}

			optionSelected = false;
		}	
	}

	/// <summary>
	/// What happens when button 1 is pressed
	/// </summary>
	public void button1Pressed() 
	{
		totalPlayerPower = insultOnePlayerPower * rnd.Next (1, 4);
		gamePause = false;
		optionSelected = true;
	}

	/// <summary>
	/// What happens when button 2 is pressed
	/// </summary>
	public void button2Pressed()
	{
		totalPlayerPower = insultTwoPlayerPower * rnd.Next (1, 4);
		gamePause = false;
		optionSelected = true;
	}

	/// <summary>
	/// What happens when button 3 is pressed
	/// </summary>
	public void button3Pressed()
	{
		totalPlayerPower = insultThreePlayerPower * rnd.Next (1, 4);
		gamePause = false;
		optionSelected = true;
	}

}