using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameSettings : MonoBehaviour {

    //MARK: Global variables
    public List<string> settings;

    //MARK: System functions

	// Use this for initialization
	void Start ()
    {
        getSettings();
	}
	
	// Update is called once per frame
	void Update ()
    {
        settingsView();
	}

    //MARK: Constant runners

    /// <summary>
    /// Gets the settings from the file and makes a list of them
    /// Every other line is the actual setting. Settings start at 0 with the first name, then 1 with the first result
    /// </summary>
    public void getSettings()
    {
        var lines = File.ReadAllLines("Assets\\Menu\\Settings\\settings.txt");
        foreach (var line in lines)
        {
            settings.Add(line);
        }
    }


    //MARK: Settings view

    //The settings text that displays whether the swearing is allowed
    public Text swearingAllowedText;

    public GameManager gameManager;
    /// <summary>
    /// What controlls the settings canvas view. Doesn't do the buttons
    /// </summary>
    public void settingsView()
    {
        //Checks line 2 of the text file for the swearing setting
        if (settings[1] == "true")
        {
            //Sets to true in game
            swearingAllowedText.text = "Yes";
            PlayerPrefs.SetString("SwearingAllowed", "true");
        }
        else
        {
            //Sets to false in game
            swearingAllowedText.text = "No";
            PlayerPrefs.SetString("SwearingAllowed", "false");
        }
    }

    //MARK: Buttons

    /// <summary>
    /// What happens when the player presses the "Swearing" button
    /// </summary>
    public void swearingPressed()
    {
        print(settings[1]);
        //Sets the swearing string in the list to whatever it's not
        if (settings[1] == "true")
        {
            settings[1] = "false";
        }
        else
        {
            settings[1] = "true";
        }
        print(settings[1]);
    }

    /// <summary>
    /// Takes each item from the list and adds it to a new line on the text file
    /// </summary>
    public void saveSettings()
    {

        var saveOption = EditorUtility.DisplayDialog(
            "Save?", //Title
            "Are you sure you want to save?", //Message
            "Yes", //Option 0
            "No" //Option 1
            );


        switch (saveOption)
        {
            // Save settings
            case true:
                //The double back slash is because backslash is escape, so to use it we have to escape the escape. 
                //Trust me, I get paid to know this shit! :P
                File.WriteAllLines("Assets\\Menu\\Settings\\settings.txt", settings.ToArray());
                break;
            // Cancel and don't save
            case false:
                
                break;

        }
    }

    /// <summary>
    /// Quits the settings screen when the quit button is pressed
    /// </summary>
    public void quitSettings()
    {
        var quitOption = EditorUtility.DisplayDialog(
            "Quit?", //Title
            "You might not have saved. Are you sure you want to quit?", //Message
            "Yes", //Option true
            "No" //Option false
            );


        switch (quitOption)
        {
            // Quit back to MainMenu
            case true:
                SceneManager.LoadScene("MainMenu");
                break;
            // Cancel
            case false:
                //Does nothing here. Closes the box
                break;
        }
    }

    
}
