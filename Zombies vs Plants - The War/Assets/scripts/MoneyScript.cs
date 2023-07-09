using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public float money = 41f;

    public void AddMoney(float amount)
    {
        money += amount;
        Debug.Log(amount);
        Debug.Log("Money added");
    }
}
