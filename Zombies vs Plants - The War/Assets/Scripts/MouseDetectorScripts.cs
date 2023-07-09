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
    public MoneyScript moneyscript;
    public GameObject shieldZombie;

    GameObject currentZombie;

    private void Start()
    {
        currentZombie = regularZombie;
    }

    private void Update()
    {
        if (ZombieTypeDetector.selectedZombie == "RegularZombie" && moneyscript.money >= 40f)
        {
            currentZombie = regularZombie;
        }
        else if (ZombieTypeDetector.selectedZombie == "ShieldZombie" && moneyscript.money >= 80f)
        {
            currentZombie = shieldZombie;
        }


        zombieSpawnPosition = new Vector3(transform.position.x, transform.position.y + tileDifference, transform.position.z);

        spawnTimer += Time.deltaTime;
    }

    private void OnMouseDown()
    {
        if (mous)
            if (spawnTimer >= spawnRateTimer && moneyscript.money >= 40f && currentZombie == regularZombie )
            {
                Instantiate(currentZombie, zombieSpawnPosition, transform.rotation);
                spawnTimer = 0f;
                moneyscript.AddMoney(-40f); 
            }
            if ( spawnTimer >= spawnRateTimer && moneyscript.money >= 80f && currentZombie == shieldZombie )
            {
                Instantiate(currentZombie, zombieSpawnPosition, transform.rotation);
                spawnTimer = 0f;
                moneyscript.AddMoney(-80f); 
            }
    }
}
