using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlantRangeDetector : MonoBehaviour
{
    public bool blueCanShoot = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Zombie")
        {
            blueCanShoot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Zombie")
        {
            blueCanShoot = false;
        }
    }
}
