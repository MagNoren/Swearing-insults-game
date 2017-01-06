using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading;

using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class NewBattleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        getInsults();
	}
	
	// Update is called once per frame
	void Update () {
        mainLoop();
        Thread.Sleep(10000);
	}

    public List<string> insults;
    public List<int> insultPowers;


    /// <summary>
    /// Gets the insults.
    /// </summary>
    /// HOLY FUCK YES IT WORKS 6/1/2017
    void getInsults() 
    {
        //For public sake
        var lines = File.ReadAllLines("Assets/Insults/cleanInsults.txt");
        //Defaults to clean
        if (PlayerPrefs.GetString("SwearingAllowed") == "true")
        {
            //Can swear
            lines = File.ReadAllLines("Assets/Insults/vulgarInsults.txt");
        }
        else
        {
            //Can't swear
            lines = File.ReadAllLines("Assets/Insults/cleanInsults.txt");
        }

        foreach (var line in lines) 
        {
            int index = Array.IndexOf(lines, line);
            //print("Index");
            //print(index);
            //print(line);

            if (index % 2 == 0)
            {
                //Is even: Add it to insults
                insults.Add(line);
                //print("Insult");
                //print(line);
            }
            else
            {
                //Is odd: Remove, add to insultPowers
                insultPowers.Add(Int32.Parse(line));
                //print("Power");
                //print(line);
            }

        }

        //print("Done");
        print(insults);
        print(insultPowers);


    }

    //The button texts
    public Text playerButtonOneText;
    public Text playerButtonTwoText;
    public Text playerButtonThreeText;
    //The player powers
    int insultOnePlayerPower;
    int insultTwoPlayerPower;
    int insultThreePlayerPower;

    int totalPlayerPower;

    void playerInsults()
    {
        //if (!gamePause)
        //{
            int insultIndex;
            System.Random rnd = new System.Random();

            insultIndex = rnd.Next(0, insults.Count);
            print("Insult Index");
            print(insultIndex);

            print(insultPowers[insultIndex]);
            print(insults[insultIndex]);

            playerButtonOneText.text = insults[insultIndex];

            //int insultIndex;
            //System.Random rnd = new System.Random();

            //insultIndex = rnd.Next(0, insults.Count);
            //playerButtonOneText.text = insults[insultIndex];
            //insultOnePlayerPower = insultPowers[insultIndex];

            //insultIndex = rnd.Next(0, insults.Count);
            //playerButtonOneText.text = insults[insultIndex];
            //insultTwoPlayerPower = insultPowers[insultIndex];

            //insultIndex = rnd.Next(0, insults.Count);
            //playerButtonOneText.text = insults[insultIndex];
            //insultThreePlayerPower = insultPowers[insultIndex];
        //}

        //gamePause = true;
    }

    void mainLoop()
    {
        //if (gamePause == false)
        //{
            //npcInsult();
            playerInsults();
            //gamePause = true;
        //}

        //optionSelect = true;

        //if (totalPlayerPower > npcInsultPower && optionSelect == false)
        //{
        //    wins += 1;
        //}
        //else if (totalPlayerPower < npcInsultPower && optionSelect == false)
        //{
        //    losses += 1;
        //}
    }


}
