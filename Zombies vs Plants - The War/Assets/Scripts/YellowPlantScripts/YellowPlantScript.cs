using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlantScript : MonoBehaviour
{
    public GameObject myPlant;

    public float health = 2f;

    void Update()
    {
        if (health <= 0f)
        {
            Destroy(myPlant);
        }
    }
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
        }
    }
}
