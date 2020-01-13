using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject upgradeInfo;
    public string upgradeName;
    public float cost;
    public int count;
    public int clickPower;
    private float baseCost;
    public Animator animator;

    public Click click;

    void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        upgradeInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + CurrencyConverter.Instance.GetCurrencyIntoString(cost) + "\n" + clickPower + " R$/Click";
        if (click.money >= cost)
            UpgradeButton.GetComponent<Button>().interactable = true;
         else
            UpgradeButton.GetComponent<Button>().interactable = false;
    }
    public void PurchaseUpgrade()
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
