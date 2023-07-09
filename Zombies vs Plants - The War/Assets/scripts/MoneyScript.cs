using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneyScript : MonoBehaviour
{
    
    void Start(){
        if (SceneManager.GetActiveScene().name == "Zvs.P_LevelOne"){
            money = 40f;
        }
    }
    
    
    
    public float money = 100f;

    public void AddMoney(float amount)
    {
        money += amount;
        Debug.Log(amount);
        Debug.Log("Money added");
    }
}
