using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Attach this to all NPC gameObjects
/// </summary>
public class LevelMover : MonoBehaviour {

    public OverlevelManager overlevelManager;
    public GameObject pressSpaceToProceedText;

    public int characterNumber;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// When the player enters a character, if they haven't been played before then they will show the "pressSpaceToProceedText"
    /// And then, if they press
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (overlevelManager.completedChars.Contains(characterNumber) == false)
            {
                pressSpaceToProceedText.SetActive(true);
                if (Input.GetKeyDown("Space"))
                {
                    PlayerPrefs.SetInt("characterNumber", characterNumber);
                    SceneManager.LoadScene("BattleScene");
                }
            }
        }   
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        pressSpaceToProceedText.SetActive(false);
    }
}
