using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ZombieTypeDetector : MonoBehaviour
{
    public static string selectedZombie;

    public MoneyScript moneyScript;

    public TextMeshProUGUI moneyText;

    string moneyAmount;

    private void Start()
    {
        moneyScript = FindAnyObjectByType<MoneyScript>();
    }

    void Update()
    {
        moneyAmount =  moneyScript.money.ToString();
        moneyText.text = moneyAmount;
    }

    public void Click(string zombieType)
    {
        selectedZombie = zombieType;
    }    
}
