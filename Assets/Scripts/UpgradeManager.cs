using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public GameObject upgradeInfo;
    public string upgradeName;
    public float cost;
    public int count;
    public int clickPower;
    private float baseCost;
    public Animator animator;

    void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        upgradeInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + cost + "\n" + clickPower + " R$/Click";
    }
    public void PurchaseUpgrade(Click click)
    {
        if (click.money >= cost)
        {
            click.money -= cost;
            click.moneyPerClick += clickPower;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.80f, count));
        } else{
            animator.SetTrigger("NoMoney");
        }
    }
}
