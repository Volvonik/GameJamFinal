using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetectorScripts : MonoBehaviour
{
    public float tileDifference = 0.05f;
    Vector3 zombieSpawnPosition;

    float spawnTimer;
    float spawnRateTimer = 1f;

    public GameObject regularZombie;
    public GameObject shieldZombie;

    public GameObject currentZombie;

    private void Update()
    {
        zombieSpawnPosition = new Vector3(transform.position.x, transform.position.y + tileDifference, transform.position.z);

        spawnTimer += Time.deltaTime;
    }

    private void OnMouseDown()
    {
        Instantiate(regularZombie, zombieSpawnPosition, transform.rotation);
    }
}
