using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlantScript : MonoBehaviour
{
    public float blueHealth = 3f;

    void Update()
    {
        if (blueHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            blueHealth -= Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Debug.Log("F8Ck");
        }
    }
}