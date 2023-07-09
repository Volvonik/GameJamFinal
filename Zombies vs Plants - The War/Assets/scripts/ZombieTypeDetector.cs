using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ZombieTypeDetector : MonoBehaviour
{
    public static string selectedZombie;

    public MoneyScript moneyScript;

    public Text moneyText;

    float moneyAmount;

    void Update()
    {
        moneyAmount =  moneyScript.money;
        moneyText.text = "test";//moneyAmount.ToString();
        Debug.Log(moneyText.text);
    }

    public void Click(string zombieType)
    {
        selectedZombie = zombieType;
    }    
}
