using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlevelManager : MonoBehaviour {

    public GameObject Char1;
    public GameObject Char2;
    public GameObject Char3;
    public GameObject Char4;
    public GameObject Char5;
    public GameObject Char6;
    public GameObject Char7;
    public GameObject Char8;

    public GameObject Char1Status;
    public GameObject Char2Status;
    public GameObject Char3Status;
    public GameObject Char4Status;
    public GameObject Char5Status;
    public GameObject Char6Status;
    public GameObject Char7Status;
    public GameObject Char8Status;
    



    private SpriteRenderer spriteRenderer;

    public List<int> wonAgainstChars;
    public List<int> lostAgainstChars;

    public List<int> completedChars;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Sprite wonAgainstSprite;
    public Sprite lostAgainstSprite;

    void wonMarks()
    {
        if (wonAgainstChars.Contains(1))
        {
            spriteRenderer = Char1Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(2))
        {
            spriteRenderer = Char2Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(3))
        {
            spriteRenderer = Char3Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(4))
        {
            spriteRenderer = Char4Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(5))
        {
            spriteRenderer = Char5Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(6))
        {
            spriteRenderer = Char6Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(7))
        {
            spriteRenderer = Char7Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
        if (wonAgainstChars.Contains(8))
        {
            spriteRenderer = Char8Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = wonAgainstSprite;
        }
    }

    void lostMarks()
    {
        if (lostAgainstChars.Contains(1))
        {
            spriteRenderer = Char1Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(2))
        {
            spriteRenderer = Char2Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(3))
        {
            spriteRenderer = Char3Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(4))
        {
            spriteRenderer = Char4Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(5))
        {
            spriteRenderer = Char5Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(6))
        {
            spriteRenderer = Char6Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(7))
        {
            spriteRenderer = Char7Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
        if (lostAgainstChars.Contains(8))
        {
            spriteRenderer = Char8Status.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = lostAgainstSprite;
        }
    }


}
