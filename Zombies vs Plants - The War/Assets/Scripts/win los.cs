using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlos : MonoBehaviour
{
    public static ddeathCounter ;
    public static zombieCounter ;
    public static bool lose;
    public static bool win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ddeathCounter == zombieCounter && moneyscript.money < 40)
        {
            lose = true
        }
    }

}
