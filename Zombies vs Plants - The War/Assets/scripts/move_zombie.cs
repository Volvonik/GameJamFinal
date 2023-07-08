using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_zombie : MonoBehaviour
{
    public GameObject controlledPlayer;

    float tileWidth = 1f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            controlledPlayer.transform.Translate(0, -tileWidth, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            controlledPlayer.transform.Translate(0, tileWidth, 0);
        }
    }
}
