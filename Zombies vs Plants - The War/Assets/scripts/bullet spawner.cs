using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    
    public GameObject bullet;
    public float spawn_rate = 1f;
    private float timer = 0f; 

    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawn_rate){
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            timer = 0f;
        }
    }
}
