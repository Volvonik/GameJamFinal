using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldZombieMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float ShieldZombieSpeed = -20f;
    public float SlowedSpeed = -15f;

    public bool isDead = false;

    public float ShieldZombieHealth = 16f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(ShieldZombieSpeed * Time.fixedDeltaTime, 0);
    }

    private void Update()
    {
        if (ShieldZombieHealth <= 0f)
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
            ShieldZombieHealth -= 3f;
            print(ShieldZombieHealth);
        }
        if (other.tag == "BlueBullet")
        {
            ShieldZombieSpeed = SlowedSpeed;
            ShieldZombieHealth -= 1;
            Invoke("restorespeed", 3);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            Debug.Log("House Collision!");
        }


    }

    private void restorespeed()
    {
        ShieldZombieSpeed = -20;
    }
}
