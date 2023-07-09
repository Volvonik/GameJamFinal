using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    public float regularSpeed = -25f;
    public float zombieSpeed = -25f;
    public float slowedSpeed = -15f;

    public bool isDead = false;

    public float zombieHealth = 12f;

    public float yellowPlantDamage = 3f;
    public float bluePlantDamage = 1f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
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
        if (zombieHealth <= 10f && gameObject.layer == 6)
        {
            anim.Play("NoShieldZombie");

            zombieSpeed = -25f;
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
            TakeDamage(yellowPlantDamage);
            print(zombieHealth);
        }
        if (other.tag == "BlueBullet")
        {
            zombieSpeed = slowedSpeed;
            TakeDamage(bluePlantDamage);
            Invoke("RestoreSpeed", 3);
        }
        if (other.tag == "BannaPeel")
        {
            zombieSpeed = 0;
            Invoke("RestoreSpeed",2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            Debug.Log("House Collision!");
        }
        else if(collision.gameObject.tag == "BannaPeel")
        {
            zombieSpeed = 0;
            Invoke("RestoreSpeed",50);
        }
    }

    public void RestoreSpeed()
    {
        zombieSpeed = regularSpeed;
    }
    public void TakeDamage(float damage)
    {
        zombieHealth -= damage;
    }
    
}
