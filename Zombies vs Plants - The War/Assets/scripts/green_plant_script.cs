using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green_plant_script : MonoBehaviour
{
        public float health = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f){
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collider){
        if (collider.gameObject.tag == "Player"){
            health -= Time.deltaTime;
            //Debug.Log(health);
        }
    }
}
