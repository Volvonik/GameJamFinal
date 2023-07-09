using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBulletSpawnerScript : MonoBehaviour
{
    public GameObject bullet;

    public float spawnRate = 1.7f;
    private float spawnRateTimer = 0f;

    int randomNumber;

    AudioSource audioSource;

    public AudioClip shootSFX1;
    public AudioClip shootSFX2;
    public AudioClip shootSFX3;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        spawnRateTimer = 0f;
    }

    void Update()
    {
        spawnRateTimer += Time.deltaTime;

        if (spawnRateTimer >= spawnRate)
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        randomNumber = Random.Range(1, 3);

        if (randomNumber == 1)
        {
            audioSource.PlayOneShot(shootSFX1);
        }
        else if (randomNumber == 2)
        {
            audioSource.PlayOneShot(shootSFX2);
        }
        else if (randomNumber == 3)
        {
            audioSource.PlayOneShot(shootSFX3);
        }

        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);

        spawnRateTimer = 0f;
        randomNumber = 0;
    }
}
