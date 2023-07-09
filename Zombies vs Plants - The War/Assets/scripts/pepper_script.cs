using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepper_script : MonoBehaviour
{
    public float health = 2f;
    bool IsAttacked = false;
    ZombieMovement zombieScript;
    // Start is called before the first frame update
    void Start()
    {
        health = 2f;                    
        

    }

    // Update is called once per frame
    void Update()
    {
        if (health<=0f && IsAttacked){
            zombieScript.TakeDamge(13);
            Debug.Log("exploded");
            Destroy(gameObject);
            
            
            
        }
        
    }
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
            IsAttacked = true;

        }
        else
        {
            IsAttacked = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
            if (other.gameObject.tag == "Zombie" ){
                zombieScript = other.gameObject.GetComponent<ZombieMovement>();

                


            } 
            
        
    }
}
