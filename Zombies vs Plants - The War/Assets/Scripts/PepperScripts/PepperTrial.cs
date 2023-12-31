using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperTrial : MonoBehaviour
{
    ZombieMovement zombieScript;
    public MoneyScript moneyScript;

    public float health = 2f;
    public float pepperValue = 20f;

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
        moneyScript.AddMoney(pepperValue);

        zombieScript.TakeDamage(damage);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
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
