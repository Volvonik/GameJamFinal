using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float zombieSpeed = -70f;

    bool isDead = false;

    public float eatTimer;
    public float roundedEatTimer;

    public float greenPlantEatingTime = 2f;
    public float potatoEatingTime = 4f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        roundedEatTimer = Mathf.Round(eatTimer);
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(zombieSpeed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (isDead == false)
        {
            eatTimer += Time.deltaTime;
            

            //if (other.gameObject.tag == "Potato" && roundedEatTimer >= potatoEatingTime)
            //{
            //    Destroy(other.gameObject);
            //}

            //if (other.gameObject.tag == "GreenPlant" && roundedEatTimer >= greenPlantEatingTime)
            //{
            //    Destroy(other.gameObject);
            //}
        }
        if (other.gameObject.tag == "house"){
            Debug.Log("you won!");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        eatTimer = 0f;
    }
    
}
