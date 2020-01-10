using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePerSec : MonoBehaviour
{
    public GameObject upgradeSecInfo;
    public string upgradeName;
    public float cost;
    public int count;
    public int moneySec;
    private float baseCost;

    public Animator animator;

    void Start()
    {
        baseCost = cost;
    }
    void Update()
    {
        upgradeSecInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + cost + "\n" + moneySec + " R$/Sec";
    }

    public void PurchaseUpgradeSec(Click click)
    {
        if (click.money >= cost)
        {
            click.money -= cost;
            click.moneyPerSec += moneySec;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.80f, count));
        } else
        {
            animator.SetTrigger("NoMoney");
        }
    }
}
