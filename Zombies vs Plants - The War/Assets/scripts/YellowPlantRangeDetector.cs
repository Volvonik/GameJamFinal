using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class YellowPlantRangeDetector : MonoBehaviour
{
    public bool yellowCanShoot = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Zombie")
        {
            yellowCanShoot = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Zombie")
        {
            yellowCanShoot = false;
        }
    }
}
