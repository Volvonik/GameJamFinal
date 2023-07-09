using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperTrial : MonoBehaviour
{
    ZombieMovement zombieScript;

    public float health = 2f;

    public float damage = 13f;

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);

            zombieScript.TakeDamage(damage);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        zombieScript = collision.GetComponent<ZombieMovement>();
    }
}
