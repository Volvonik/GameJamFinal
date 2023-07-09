using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlantScript : MonoBehaviour
{
    public GameObject myPlant;
    public MoneyScript ms;
    public float BluePlantValue = 100f;
    public ParticleSystem eatingEffect;
    public ParticleSystem dieEffecct;
    public float blueHealth = 3f;
    public MoneyScript money_script;
 void Update()
    {
        if (blueHealth <= 0f)
        {
            Die();
            Destroy(gameObject);
            money_script.AddMoney(BluePlantValue);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            blueHealth -= Time.deltaTime;
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
