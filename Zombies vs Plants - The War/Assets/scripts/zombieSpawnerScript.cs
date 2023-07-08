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
          MousePosition.z = Camera.main.nearClipPlane +1;
          Vector3 worldPosition = Camera.main.ScreenToWorldPoint(MousePosition);
          Instantiate(zombie,new Vector3(4.8f,Block(worldPosition.y),0), transform.rotation);
          //Debug.Log("button pressed");
        }
    }
    float Block(float y){
        if (y <= 2f && y > 1f){
            return 1.25f;
        }
        else if (y <=1f && y>0f)
        {
            return 0.25f;
        }
        else if (y <= 0f && y>-1f)
        {
            return -0.725f;
        }
        else if (y <= -1f && y>-2f )
        {
            return -1.725f;
        }
        else if (y<= -2f && y>-3f)
        {
            return -2.725f;
        }
        else{
            return -0.725f;
        }
        
            
    }
}
