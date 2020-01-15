using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    
    public GameObject moneyPerClickDisplay;
    public GameObject moneyDisplay;
    public GameObject companyButton;
    public float money = 0f;
    public int moneyPerClick = 1;
    public int moneyPerSec = 0;
    public int clicks = 0;

    void Update()
    {
        moneyDisplay.GetComponent<Text>().text = "R$ " + CurrencyConverter.Instance.GetCurrencyIntoString(money);
        moneyPerClickDisplay.GetComponent<Text>().text = CurrencyConverter.Instance.GetCurrencyIntoString(moneyPerClick) + " R$/click";
    }
    public void Clicked()
    {
        money += moneyPerClick;
        clicks++;
        GlobalAchievements.ach01Count += 1;
        GlobalAchievements.ach02Count += 1;
        GlobalAchievements.ach03Count += 1;
    }
}
