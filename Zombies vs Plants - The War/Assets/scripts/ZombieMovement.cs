using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float zombieSpeed = -70f;

    public bool isDead = false;

    float zombieHealth = 12f;

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(zombieSpeed * Time.fixedDeltaTime, 0);
    }

    private void Update()
    {
        if (zombieHealth <= 0f)
        {
            isDead = true;
        }

        if (isDead == true)
        {
            Kill();
        }
    }

    private void Kill()
    {
        print("Zombie Died!");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "YellowBullet")
        {
            zombieHealth -= 3f;
            print(zombieHealth);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            Debug.Log("House Collision!");
        }
    }
}
