using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{
    public float potato_health = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (potato_health <= 0f){
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collider){
        if (collider.gameObject.tag == "Player"){
            potato_health -= Time.deltaTime;
            //Debug.Log(health);
        }
    }

}
