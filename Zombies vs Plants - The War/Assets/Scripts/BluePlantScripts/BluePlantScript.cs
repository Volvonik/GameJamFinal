using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlantScript : MonoBehaviour
{
    public GameObject myPlant;

    public float blueHealth = 3f;

    void Update()
    {
        if (blueHealth <= 0f)
        {
            Destroy(myPlant);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            blueHealth -= Time.deltaTime;
        }
    }
}
