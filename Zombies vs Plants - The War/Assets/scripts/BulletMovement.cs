using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D rb;

    Vector3 spawnerPosition;

    public float bullet_speed = 3f;

    public float bulletRange = 10f;

    public bool bulletHit = false;

    int randomNumber;

    public AudioSource audioSource;

    public AudioClip hitSFX1;
    public AudioClip hitSFX2;
    public AudioClip hitSFX3;
    public AudioClip hitSFX4;

    public AudioClip fadeSFX1;
    public AudioClip fadeSFX2;
    public AudioClip fadeSFX3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spawnerPosition = transform.position;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(bullet_speed * Time.fixedDeltaTime, 0);

        Vector3 bulletPosition = transform.position;

        if (bulletPosition.x - spawnerPosition.x >= bulletRange)
        {
            FadeOut();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Zombie")
        {
            Hit();
        }

        else if (other.tag == "Seperation")
        {
            FadeOut();
        }
    }

    void Hit()
    {
        randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {
            audioSource.PlayOneShot(hitSFX1);
        }
        else if (randomNumber == 2)
        {
            audioSource.PlayOneShot(hitSFX2);
        }
        else if (randomNumber == 3)
        {
            audioSource.PlayOneShot(hitSFX3);
        }
        else if (randomNumber == 4)
        {
            audioSource.PlayOneShot(hitSFX4);
        }

        Destroy(gameObject);
    }

    void FadeOut()
    {
        randomNumber = Random.Range(1, 3);

        if (randomNumber == 1)
        {
            audioSource.PlayOneShot(fadeSFX1);
        }
        else if (randomNumber == 2)
        {
            audioSource.PlayOneShot(fadeSFX2);
        }
        else if (randomNumber == 3)
        {
            audioSource.PlayOneShot(fadeSFX3);
        }

        Destroy(gameObject);
    }
}
