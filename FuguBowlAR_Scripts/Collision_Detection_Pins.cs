using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detection_Pins : MonoBehaviour 
{
    Scoring_System score;

	// Use this for initialization
	void Start () 
    {
        //Find the score script and use it to increase the amount of points that are gained per hit on pin.
        score = GameObject.FindWithTag("GameManager").GetComponent<Scoring_System>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    //This method if called when the collision occurs between two rigidbodies/colliders
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BowlingBall")
        {
            Debug.Log("Collision Occured with bowling ball");
            score.UpdateScore();
        }
        else
        {
            Debug.Log("Collision Occured with something other than the bowling ball");
        }
    }
}