using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is basically the settings manager. 
/// </summary>
public class GameManager : MonoBehaviour {

    public bool swearsAllowed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void getSettings()
    {
        if (PlayerPrefs.GetString("SwearingAllowed") == "true")
        {
            swearsAllowed = true;
        }
        else
        {
            swearsAllowed = false;
        }
    }

}
