using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour
{
    YellowPlantRangeDetector plantDetector;

    public GameObject bullet;

    public float spawnRate = 1f;
    private float spawnRateTimer = 0f; 

    void Start()
    {
        plantDetector = FindObjectOfType<YellowPlantRangeDetector>();

        spawnRateTimer = 0f;
    }

    void Update()
    {
        if (plantDetector.yellowCanShoot == true)
        {
            spawnRateTimer += Time.deltaTime;
        }

        if (spawnRateTimer >= spawnRate)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

            spawnRateTimer = 0f;
        }
    }
}
