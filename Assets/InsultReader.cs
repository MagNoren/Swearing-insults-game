using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System;

using UnityEngine;

public class InsultReader : MonoBehaviour {

    

    int insultIndex = 0;

	// Use this for initialization
	void Start ()
    {
        //getInsults();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    //public GameManager gameManager;
    //public void getInsults()
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
    //        //    if (index % 2 == 0)
    //        //    {
    //        //        //Is even: Leave it
    //        //    }
    //        //    else
    //        //    {
    //        //        //Is odd: Remove, add to insultPowers
    //        //        insultPowers.Add(Int32.Parse(insult));
    //        //        insults.Remove(insult);
    //        //    }
    //        //}

    //        //foreach (var item in insults)
    //        //{
    //        //    print(item.ToString());
    //        //}
    //        //foreach (var item in insultPowers)
    //        //{
    //        //    print(item.ToString());
    //        }

    //    }
    //    //else
    //    //{
    //    //    //Double backslash because \ is escape so to use \ we escape the escape
    //    //    var lines = File.ReadAllLines("Assets\\Insults\\cleanInsults.txt");
    //    //    foreach (var line in lines)
    //    //    {
    //    //        insults.Add(line);
    //    //    }
    //    //    foreach (var insult in insults)
    //    //    {
    //    //        int index = insults.IndexOf(insult.ToString());
    //    //        if (index % 2 == 0)
    //    //        {
    //    //            //Is even: Leave it
    //    //        }
    //    //        else
    //    //        {
    //    //            //Is odd: Remove, add to insultPowers
    //    //            insultPowers.Add(Int32.Parse(insult));
    //    //            insults.Remove(insult);
    //    //        }
    //    //    }
    //    //}
        
    //}
}
