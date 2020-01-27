using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UpgradePerSec : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject upgradeSecInfo;
    public string upgradeName;
    public int inicialCost;
    public float cost;
    public int count;
    public int moneySec;
    private float baseCost;
    public AudioSource cash;

    public Animator animator;

    public Animator subCash;
    public GameObject subCashText;
    public Click click;

    void Start()
    {
        baseCost = cost;
    }
    void Update()
    {
        upgradeSecInfo.GetComponent<Text>().text = upgradeName + " (" + count + ")" + "\nValor: R$ " + CurrencyConverter.Instance.GetCurrencyIntoString(cost) + "\n" + moneySec + " R$/Sec";
        if (click.money >= cost)
        {
            UpgradeButton.GetComponent<Button>().interactable = true;
        } else
            UpgradeButton.GetComponent<Button>().interactable = false;
    }

    public void PurchaseUpgradeSec()
    {
        if (click.money >= cost)
        {
            subCashText.GetComponent<Text>().text = "- R$ " + CurrencyConverter.Instance.GetCurrencyIntoString(cost);
            subCash.SetTrigger("Buy");
            cash.Play();
            click.money -= cost;
            click.moneyPerSec += moneySec;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.60f, count));
        } else
        {
            animator.SetTrigger("NoMoney");
        }
    }
}
