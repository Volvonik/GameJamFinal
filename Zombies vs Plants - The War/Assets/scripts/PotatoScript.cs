using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoScript : MonoBehaviour
{
    public float potato_health = 4f;
    private ParticleSystem particelSystem;
    float ParticelTimer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        particelSystem = GetComponent<ParticleSystem>();
        particelSystem.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        if (potato_health <= 0f){
            Destroy(gameObject);
        }
        if (ParticelTimer >= 0.5f){
            particelSystem.Stop();
        }
        ParticelTimer += Time.deltaTime;
    }
    private void OnCollisionStay2D(Collision2D collider){
        if (collider.gameObject.tag == "Player"){
            potato_health -= Time.deltaTime;
            //Debug.Log(health);
            //var particelSystemMain = particelSystem.main;
            //particelSystemMain.startLifeTime = 1f;
            particelSystem.Play();
            ParticelTimer = 0f;
            



        }
    }

}
