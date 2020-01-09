using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoMoneySec : MonoBehaviour
{
    public GameObject mpsDisplay;
    public Click click;
    public UpgradeManager[] items;

    void Start() {
        StartCoroutine (AutoTick());
    }

    void Update() {
        mpsDisplay.GetComponent<Text>().text = GetGoldPerSec() + " R$/seg";
    }

    public float GetGoldPerSec() {
        float tick = 0;
        foreach (UpgradeManager item in items)
        {
            if(item.isSec == true)
                tick += item.count * item.cost;
        }
        return tick;
    }

    public void AutoGoldPerSec() {
        click.money += GetGoldPerSec() / 10;
    }

    IEnumerator AutoTick() {
        while (true) {
            AutoGoldPerSec();
            yield return new WaitForSeconds(0.10f);
        }
    }
}
