using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepper_script : MonoBehaviour
{
    public float health = 2f;

    public float damage = 7f;

    CircleCollider2D circlec;
    CapsuleCollider2D capsulec;

    private void Start()
    {
        circlec = GetComponent<CircleCollider2D>();
        capsulec = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        if (health <= 0f)
        {
            Die();
        }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
        }
    }

    void Die()
    {
        circlec.enabled = false;
        capsulec.enabled = true;

        Destroy(gameObject);
    }
}
