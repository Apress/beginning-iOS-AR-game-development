using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring_System : MonoBehaviour 
{
    public int score;

	// Use this for initialization
	void Start () 
    {
        score = 0;  //Default value when starting the game
        //Initialization of game objects occurs in another script (Instantiate_GameObjects).
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Will use OnCollisionEnter with a script attached to the bowling pins and have it call UpdateScore below in order to update the score.
	}

    //Is called whenever a pin is hit by a bowling ball. Will increase the score by 1 (general case).
    //Alternatively, can be done on scene change/load, or init_GameObjects, so that every time the pins reset we can update the current score. Safest to just do generic case here.
    public void UpdateScore()
    {
        score++;
    }
}