using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour
{
    public GameObject bullet;

    public float spawnRate = 1f;
    private float spawnRateTimer = 0f; 

    public float bulletRange = 2f;

    public LayerMask layersToHit;

    bool bulletHasTarget = false;

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

        if (bulletHasTarget == false)
        {
            Debug.Log("Jeez");
        }
        else if (bulletHasTarget == true)
        {
            Debug.Log("Yay!");
        }
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, bulletRange * 2);
        Debug.DrawRay(transform.position, Vector2.right * hit.distance, Color.red);

        if (hit.collider != null)
        {
            bulletHasTarget = false;
            Debug.Log(bulletHasTarget);
        }

        else
        {
            bulletHasTarget = true;
            Debug.Log(bulletHasTarget);
        }
    }
}
