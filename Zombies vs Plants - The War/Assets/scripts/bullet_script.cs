using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float bullet_speed = 1f;
    public GameObject self;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(bullet_speed * Time.fixedDeltaTime, 0);
    }
    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            Destroy(self);
        }
        
    }


}
