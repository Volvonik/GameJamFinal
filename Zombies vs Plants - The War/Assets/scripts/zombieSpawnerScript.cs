using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawnerScript : MonoBehaviour
{
    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
          Vector3 MousePosition = Input.mousePosition;
          Instantiate(zombie,new Vector3(8.25f,MousePosition.y,0), transform.rotation);
          Debug.Log("button pressed");
        }
    }
}
