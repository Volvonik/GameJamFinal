using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBulletSpawnerScript : MonoBehaviour
{
    public GameObject bullet;

    public float spawnRate = 1.7f;
    private float spawnRateTimer = 0f; 

    void Start()
    {
        spawnRateTimer = 0f;
    }

    void Update()
    {
        spawnRateTimer += Time.deltaTime;

        if (spawnRateTimer >= spawnRate)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

            spawnRateTimer = 0f;
        }
    }
}
