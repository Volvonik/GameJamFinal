using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ZombieTypeDetector : MonoBehaviour
{
    public static string selectedZombie;

    public MoneyScript moneyScript;

    Text moneyText;

    int moneyAmount;

    void Update()
    {
        moneyAmount = (int) moneyScript.money;
        moneyText.text = moneyAmount.ToString();
        Debug.Log(moneyText.text);
    }

    public void Click(string zombieType)
    {
        selectedZombie = zombieType;
    }    
}
