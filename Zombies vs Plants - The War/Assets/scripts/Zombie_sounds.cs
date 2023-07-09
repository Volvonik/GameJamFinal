using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_sounds : MonoBehaviour
{   
    //ZS = zombie sound
    public AudioSource ZS1;
    public AudioSource ZS2;
    public AudioSource ZS3;
    float timer = 0;
    int Wsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 3)
        {
            Wsound = Random.Range(1, 4);
            if(Wsound == 1)
            {
                ZS1.Play();
            }
            if (Wsound == 2)
            {
                ZS2.Play();
            }
            if(Wsound == 3)
            {
                ZS3.Play();
            }
            timer = 0;



        }
    }
}
