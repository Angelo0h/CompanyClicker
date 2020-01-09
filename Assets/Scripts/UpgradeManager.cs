using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public GameObject upgradeInfo;
    public GameObject upgradeSecInfo;
    public string upgradeName;
    public float cost;
    public int count;
    public int clickPower;
    public int moneySec;
    public bool isSec = false;


    void Update()
    {
        upgradeSecInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + cost + "\n" + moneySec + " R$/Sec";
        upgradeInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + cost + "\n" + clickPower + " R$/Click";


    }
    public void PurchaseUpgrade(Click click)
    {
        if (isSec)
            this.PurchaseUpgradeSec(click);
        else
            this.PurchaseUpgradeClicked(click);
    }

    private void PurchaseUpgradeSec(Click click)
    {
        if (click.money >= cost)
        {
            click.money -= cost;
            click.moneyPerSec += moneySec;
            count++;
        }
    }

    private void PurchaseUpgradeClicked(Click click)
    {
        if (click.money >= cost)
        {
            click.money -= cost;
            click.moneyPerClick += clickPower;
            count++;
        }
    }
}
