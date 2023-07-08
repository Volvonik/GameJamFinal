using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_zombie : MonoBehaviour
{
    public GameObject controlledPlayer;
    private float ZombieHealth = 6f;
    float tileWidth = 1f;
    //public bullet_script bulletScript;

   void Start(){
    ZombieHealth = 6f;
    //bulletScript = FindObjectOfType<bullet_script>();
    
   }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            controlledPlayer.transform.Translate(0, -tileWidth, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            controlledPlayer.transform.Translate(0, tileWidth, 0);
        }
        
        if (ZombieHealth <= 1){
            Debug.Log("You died!");
            Destroy(gameObject);
        }

    }
    private void OnCollisionEntered2D(Collider2D other){
        if (other.gameObject.tag == "bullet"){
            ZombieHealth -= 1f;
            Debug.Log("hit");
        }
    }

}
