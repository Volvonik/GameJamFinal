  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaScript : MonoBehaviour
{
    public GameObject myBanana;
    public ParticleSystem dieEffecct;
    public GameObject BananaParent;
    public ParticleSystem eatingEffect;
    public float BananaValue = 30f;
    public MoneyScript moneys;

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
            eatingEffect.Play();
            health -= Time.deltaTime;
            eatingEffect.Play();
            
        }
        
        
    }
    void Die()
    {
        eatingEffect.Stop();
        dieEffecct.Play();
        moneys.AddMoney(BananaValue);
        Destroy(gameObject);
    }
        
                
 
}
