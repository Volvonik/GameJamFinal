using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTypeDetector : MonoBehaviour
{
    MouseDetectorScripts mouseScript;

    public static string selectedZombie;

    private void Start()
    {
        mouseScript = FindObjectOfType<MouseDetectorScripts>();
    }

    public void Click(string zombieType)
    {
        selectedZombie = zombieType;
    }    
}
