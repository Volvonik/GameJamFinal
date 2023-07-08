using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlantScript : MonoBehaviour
{
    public float health = 2f;

    void Update()
    {
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collider){
        if (collider.gameObject.tag == "Player"){
            health -= Time.deltaTime;
        }
    }
}
