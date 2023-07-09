using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlantScript : MonoBehaviour
{
    public GameObject myPlant;
    public MoneyScript money_script;
    public float YelowPlantValue = 50f;
    public ParticleSystem eatingEffect;
    public ParticleSystem dieEffecct;

    public float health = 2f;

    void Update()
    {
        if (health <= 0f)
        {
            Die();
            Destroy(myPlant);
            money_script.AddMoney(YelowPlantValue);
        }
    }
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
            eatingEffect.Play();
        }

    }
    void Die()
    {
        eatingEffect.Stop();
        dieEffecct.Play();
        money_script.AddMoney(YelowPlantValue);
        Destroy(gameObject);
    }
}
