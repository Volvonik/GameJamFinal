using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperTrial : MonoBehaviour
{
    ZombieMovement zombieScript;

    public float health = 2f;

    public float damage = 13f;

    public ParticleSystem dieEffect;
    public ParticleSystem eatingEffect;

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        dieEffect.Play();
        eatingEffect.Stop();

        Destroy(gameObject);

        zombieScript.TakeDamage(damage);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;

            eatingEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            eatingEffect.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        zombieScript = collision.GetComponent<ZombieMovement>();
    }
}
