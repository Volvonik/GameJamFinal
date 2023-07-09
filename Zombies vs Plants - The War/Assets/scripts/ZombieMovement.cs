using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float zombieSpeed = -25f;
    public float slowedSpeed = -15f;

    public bool isDead = false;

    public float zombieHealth = 12f;

    public bool canGetShot = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
        if (other.tag == "BlueBullet")
        {
            zombieSpeed = slowedSpeed;
            zombieHealth -= 1;
            Invoke("restorespeed", 3);
        }
        else if (other.tag == "Seperation")
        {
            canGetShot = true;
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
        zombieSpeed = -70;
    }
}
