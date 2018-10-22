using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_GameObjects : MonoBehaviour
{
    public GameObject bowlingBallPrefab;    //Used to store the bowling ball prefab and create an object based on that.
    public GameObject bowlingPinPrefab;     //Used to store the bowling pin prefab and create an object based on that.

    public Transform terrain; //Here just to easily double check if we are finding the correct plane object.

    public bool once = false;

    // Update is called once per frame
    void LateUpdate()
    {
        //Look for a plane with the tag "Terrain" that will be generated based off another script and a prefab attached to it.
        terrain = GameObject.FindWithTag("Terrain").transform;
        if (once && (terrain != null))
        {
            once = false;
            InstantiateGameObjects(terrain.position);
        }
    }

    //Create a Bowling Ball and Pin Rack slightly above the plane/terrain/bowling lane.
    //Called from the ARGeneratePlane script, so that immediately after the plane is created, the game objects are too with minimal resource usage.

    public void InstantiateGameObjects(Vector3 plane)
    {
        once = false;

        plane.y += 0.5f;   //Make sure that the objects appear above the plane.

        //Make sure the the objects appear towards the middle of the plane.
        if(plane.x >= 0)
        {
            plane.x += 2;
        }
        else
        {
            plane.x += -2;
        }

        Instantiate(bowlingBallPrefab, plane, Quaternion.identity);  //Create the Pin Rack


    }
}