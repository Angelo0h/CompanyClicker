using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoMoneySec : MonoBehaviour
{
    public GameObject mpsDisplay;
    public Click click;
    public UpgradePerSec[] items;

    void Start() {
        StartCoroutine (AutoTick());
    }

    void Update() {
        mpsDisplay.GetComponent<Text>().text = GetMoneyPerSec() + " R$/sec";
    }

    public float GetMoneyPerSec() {
        float tick = 0;
        foreach (UpgradePerSec item in items)
        {
            if(item.count > 0)
                tick += item.count * item.moneySec;
        }
        return tick;
    }

    public void AutoMoneyPerSec() {
        click.money += GetMoneyPerSec() / 10;
    }

    IEnumerator AutoTick() {
        while (true) {
            AutoMoneyPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }
}
