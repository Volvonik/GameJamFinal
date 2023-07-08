using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{
    public float potato_health = 4f;

    public ParticleSystem eatingEffect;

    public ParticleSystem dieEffect;

    private void OnCollisionStay2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "Zombie")
        {
            potato_health -= Time.deltaTime;

            if (potato_health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        eatingEffect.Stop();
        dieEffect.Play();

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            eatingEffect.Play();
        }
    }
}
