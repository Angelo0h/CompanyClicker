using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Text CompanyNameDisplay;
    public GameObject moneyPerClickDisplay;
    public GameObject moneyDisplay;
    //public GameObject companyButton;
    public float money = 0f;
    public float totalMoney = 0f;
    public int moneyPerClick = 1;
    public int moneyPerSec = 0;
    public int clicks = 0;

    void Awake()
    {
        CompanyNameDisplay.text = PlayerPrefs.GetString ("CompanyName");
    }

    void Update()
    {
        moneyDisplay.GetComponent<Text>().text = "R$ " + CurrencyConverter.Instance.GetCurrencyIntoString(money);
        moneyPerClickDisplay.GetComponent<Text>().text = CurrencyConverter.Instance.GetCurrencyIntoString(moneyPerClick) + " R$/click";
        GlobalAchievements.ach04Count = totalMoney;
    }
    public void Clicked()
    {
        money += moneyPerClick;
        totalMoney += moneyPerClick;
        clicks++;
        GlobalAchievements.ach01Count = clicks;
        GlobalAchievements.ach02Count = clicks;
        GlobalAchievements.ach03Count = clicks;
    }

    public void FoiTudoProSaco()
    {
        PlayerPrefs.DeleteAll();
    }

    
}
