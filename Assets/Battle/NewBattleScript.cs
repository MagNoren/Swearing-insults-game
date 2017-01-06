using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class NewBattleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        getInsults();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public List<string> insults;
    public List<int> insultPowers;

    /// <summary>
    /// Gets the insults.
    /// </summary>
    /// HOLY FUCK YES IT WORKS 6/1/2017
    void getInsults() 
    {
        var lines = File.ReadAllLines("Assets/Insults/vulgarInsults.txt");
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
                print("Insult");
                print(line);
            }
            else
            {
                //Is odd: Remove, add to insultPowers
                insultPowers.Add(Int32.Parse(line));
                print("Power");
                print(line);
            }

        }

        print("Done");
        //print(insults);
        //print(insultPowers);


    }

    //void getSomeInsults() 
    //{
            

    //    if (gameManager.swearsAllowed == true)
    //    {
    //        var lines = File.ReadAllLines("Assets\\Insults\\vulgarInsults.txt");
    //        foreach (var line in lines)
    //        {
    //            insults.Add(line);
    //        }
    //        foreach (var insult in insults)
    //        {
    //            int index = insults.IndexOf(insult);
    //            print(insult);
    //            print(index);
    //                if (index % 2 == 0)
    //                {
    //                    //Is even: Leave it
    //                }
    //                else
    //             {
    //                    //Is odd: Remove, add to insultPowers
    //                    insultPowers.Add(Int32.Parse(insult));
    //                    insults.Remove(insult);
    //             }
    //         }

    //            foreach (var item in insults)
    //            {
    //                print(item.ToString());
    //            }
    //            foreach (var item in insultPowers)
    //            {
    //                print(item.ToString());
    //            }

    //    }
    //    else
    //    {
    //        //Double backslash because \ is escape so to use \ we escape the escape
    //        var lines = File.ReadAllLines("Assets\\Insults\\cleanInsults.txt");
    //        foreach (var line in lines)
    //        {
    //            insults.Add(line);
    //        }
    //        foreach (var insult in insults)
    //        {
    //            int index = insults.IndexOf(insult.ToString());
    //            if (index % 2 == 0)
    //            {
    //                //Is even: Leave it
    //            }
    //            else
    //            {
    //                //Is odd: Remove, add to insultPowers
    //                insultPowers.Add(Int32.Parse(insult));
    //                insults.Remove(insult);
    //            }
    //        }
    //    }
    //}
}
