using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour
{
    public GameObject myBanana;
    public ParticleSystem dieEffecct;
    public ParticleSystem eatingEffect;

    public float health = 3f;
    void Update()
    {
        if (health <= 0f)
        {
            Die();
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
            eatingEffect.Play();
        }
    }
    void Die()
    {
        eatingEffect.Stop();
        dieEffecct.Play();
        Destroy(gameObject);
    }
        
                
 
}
