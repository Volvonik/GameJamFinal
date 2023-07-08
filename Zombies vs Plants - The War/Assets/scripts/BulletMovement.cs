using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float bullet_speed = 3f;

    public bool bulletHit = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(bullet_speed * Time.fixedDeltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player")
        {
            bulletHit = true;
            Destroy(gameObject);
            bulletHit = false;
        }
        
        
    }


}
