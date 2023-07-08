using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    float tileWidth = 48f;
    float tileDistance;
    public GameObject player;

    bool isDying = false;

    Vector2 plantPosition;
    Vector2 zombiePosition;
    
    private void Update()
    {    
        if (plantPosition.x + tileWidth * tileDistance == zombiePosition.x)
        {
            isDying = true;
            //The zombie is one block away from the plant
        }
        else
        {
            isDying = false;
            //The zombie is not one block away from the plant
        }
        
    }
}
