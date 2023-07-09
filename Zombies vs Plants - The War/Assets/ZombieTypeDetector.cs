using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTypeDetector : MonoBehaviour
{
    public static string selectedZombie;

    public void Click(string zombieType)
    {
        selectedZombie = zombieType;
    }    
}
