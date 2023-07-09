using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public float money = 41f;
    // Start is called before the first frame update
    void Start()
    {
        money = 41f;
    }

    // Update is called once per frame
    void Update()
    {
        if (money < 0f)
        {
            money = 0f;
        }
    }
    public void AddMoney(float amount)
    {
        money += amount;
        Debug.Log(amount);
        Debug.Log("Money added");
    }
}
