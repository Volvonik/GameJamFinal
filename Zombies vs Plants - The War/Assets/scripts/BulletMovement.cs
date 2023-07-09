using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D rb;

    Vector3 spawnerPosition;

    public float bullet_speed = 3f;

    public float bulletRange = 10f;

    public bool bulletHit = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spawnerPosition = transform.position;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(bullet_speed * Time.fixedDeltaTime, 0);

        Vector3 bulletPosition = transform.position;

        if (bulletPosition.x - spawnerPosition.x >= bulletRange)
        {
            FadeOut();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Zombie")
        {
            Hit();
        }

        else if (other.tag == "Seperation")
        {
            FadeOut();
        }
    }

    void FadeOut()
    {
        Debug.Log("No Targets");
        Destroy(gameObject);
    }

    void Hit()
    {
        Debug.Log("Hit!");
        Destroy(gameObject);
    }
}
