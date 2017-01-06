using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BattleScript : MonoBehaviour {

    public GameManager gameManager;
    public OverlevelManager overlevelManager;

    List<string> insults;
    List<int> insultPowers;

    int wins;
    int losses;

    int npcNumber = 1;

    public bool gamePause = false;

    public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start ()
    {
        //npcNumber = PlayerPrefs.GetInt("characterNumber");
        getInsults();
	}

    public GameObject npcObject;

    public Sprite char1Sprite;
    public Sprite char2Sprite;
    public Sprite char3Sprite;
    public Sprite char4Sprite;
    public Sprite char5Sprite;
    public Sprite char6Sprite;
    public Sprite char7Sprite;
    public Sprite char8Sprite;

    void setSprites()
    {
        spriteRenderer = npcObject.GetComponent<SpriteRenderer>();
        if (npcNumber == 1)
        {
            spriteRenderer.sprite = char1Sprite;
        }
        if (npcNumber == 2)
        {
            spriteRenderer.sprite = char2Sprite;
        }
        if (npcNumber == 3)
        {
            spriteRenderer.sprite = char3Sprite;
        }
        if (npcNumber == 4)
        {
            spriteRenderer.sprite = char4Sprite;
        }
        if (npcNumber == 5)
        {
            spriteRenderer.sprite = char5Sprite;
        }
        if (npcNumber == 6)
        {
            spriteRenderer.sprite = char6Sprite;
        }
        if (npcNumber == 7)
        {
            spriteRenderer.sprite = char7Sprite;
        }
        if (npcNumber == 8)
        {
            spriteRenderer.sprite = char8Sprite;
        }

    }

    /// <summary>
    /// Checks if the player has won or lost
    /// </summary>
    void checkWins()
    {
        if (wins == 3)
        {
            gamePause = true;
            overlevelManager.wonAgainstChars.Add(npcNumber);
            overlevelManager.completedChars.Add(npcNumber);
            EditorUtility.DisplayDialog(
            "You win!", //Title
            "Well done!", //Message
            "Ok", //Option 0
            "" //Option 1
            );
        }
        if (losses == 3)
        {
            gamePause = true;
            EditorUtility.DisplayDialog(
            "You lost!", //Title
            "Well done!", //Message
            "Ok", //Option 0
            "" //Option 1
            );

        }
    }

	// Update is called once per frame
	void Update ()
    {
        checkWins();
        mainLoop();
	}

    //MARK: Mainloop
    void mainLoop()
    {
        if (gamePause == false)
        {
            npcInsult();
            playerInsults();
            gamePause = true;
        }

        optionSelect = true;

        if (totalPlayerPower > npcInsultPower && optionSelect == false)
        {
            wins += 1;
        }
        else if (totalPlayerPower < npcInsultPower && optionSelect == false)
        {
            losses += 1;
        }
    }

    public GameObject win1;
    public GameObject win2;
    public GameObject win3;

    public GameObject loss1;
    public GameObject loss2;
    public GameObject loss3;

    void scoreBoard()
    {
        if (wins == 1)
        {

        }
    }

    public void getInsults()
    {
        if (gameManager.swearsAllowed == true)
        {
            var lines = File.ReadAllLines("Assets\\Insults\\vulgarInsults.txt");
            foreach (var line in lines)
            {
                insults.Add(line);
            }
            foreach (var insult in insults)
            {
                int index = insults.IndexOf(insult);
                print(insult);
                print(index);
                //    if (index % 2 == 0)
                //    {
                //        //Is even: Leave it
                //    }
                //    else
                //    {
                //        //Is odd: Remove, add to insultPowers
                //        insultPowers.Add(Int32.Parse(insult));
                //        insults.Remove(insult);
                //    }
                //}

                //foreach (var item in insults)
                //{
                //    print(item.ToString());
                //}
                //foreach (var item in insultPowers)
                //{
                //    print(item.ToString());
            }

        }
        //else
        //{
        //    //Double backslash because \ is escape so to use \ we escape the escape
        //    var lines = File.ReadAllLines("Assets\\Insults\\cleanInsults.txt");
        //    foreach (var line in lines)
        //    {
        //        insults.Add(line);
        //    }
        //    foreach (var insult in insults)
        //    {
        //        int index = insults.IndexOf(insult.ToString());
        //        if (index % 2 == 0)
        //        {
        //            //Is even: Leave it
        //        }
        //        else
        //        {
        //            //Is odd: Remove, add to insultPowers
        //            insultPowers.Add(Int32.Parse(insult));
        //            insults.Remove(insult);
        //        }
        //    }
        //}

    }


    //MARK: NPC Insults
    public Text npcInsultText;
    int npcInsultPower;
    public void npcInsult()
    {
        System.Random rnd = new System.Random();
        int insultIndex = rnd.Next(0, insults.Count);
        npcInsultText.text = insults[insultIndex];
        int randomInsultPower = rnd.Next(1, 4);
        npcInsultPower = insultIndex * randomInsultPower;
    }

    //MARK: Player insults

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
        if (!gamePause)
        {
            int insultIndex;
            System.Random rnd = new System.Random();

            insultIndex = rnd.Next(0, insults.Count);
            playerButtonOneText.text = insults[insultIndex];
            insultOnePlayerPower = insultPowers[insultIndex];

            insultIndex = rnd.Next(0, insults.Count);
            playerButtonOneText.text = insults[insultIndex];
            insultTwoPlayerPower = insultPowers[insultIndex];

            insultIndex = rnd.Next(0, insults.Count);
            playerButtonOneText.text = insults[insultIndex];
            insultThreePlayerPower = insultPowers[insultIndex];
        }
        
        gamePause = true;
    }

    //MARK: Player buttons

    bool optionSelect;

    public void playerButtonOnePressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        int totalPlayerPower = delivery * insultOnePlayerPower;

        optionSelect = false;
    }

    public void playerButtonTwoPressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        int totalPlayerPower = delivery * insultTwoPlayerPower;

        optionSelect = false;
    }

    public void playerButtonThreePressed()
    {
        System.Random rnd = new System.Random();

        int delivery = rnd.Next(1, 4);

        totalPlayerPower = delivery * insultThreePlayerPower;

        optionSelect = false;
    }
}

