using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepper_script : MonoBehaviour
{
    public float health = 2f;
    // Start is called before the first frame update
    void Start()
    {
        health = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health<=0){
            Destroy(gameObject);
            Debug.Log("exploded");
        }
    }
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Zombie")
        {
            health -= Time.deltaTime;
        }
    }
}
