using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannaSpawner : MonoBehaviour
{
    public GameObject bannaPell;
    public float bannaSpawnRate = 3f;

    // Start is called before the first frame update
    void Start()
    {
        private float timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (bannaSpawnRate <timer)
        {
            SpawnBanna();
            timer = 0f;
        }
    }
    private void SpawnBanna(){
        Instantiate(bannaPell, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
