using UnityEngine;
public class UIManager : MonoBehaviour
{

    void Update()
    {
        MapValueToPlayer();
    }

    void MapValueToPlayer()
    {
        Player player = GameObject.FindObjectOfType<Player>();
        Click click = GameObject.FindObjectOfType<Click>();
        UpgradePerSec[] upgradePerSecs = GameObject.FindObjectsOfType<UpgradePerSec>();
        UpgradeManager[] upgradeManagers = GameObject.FindObjectsOfType<UpgradeManager>();
        AutoMoneySec autoMoneySec = GameObject.FindObjectOfType<AutoMoneySec>();

        player.myStats.totalMoney = float.Parse(click.totalMoney.ToString());
        player.myStats.money = float.Parse(click.money.ToString());
        player.myStats.moneyPerClick = int.Parse(click.moneyPerClick.ToString());
        player.myStats.moneyPerSec = int.Parse(autoMoneySec.GetMoneyPerSec().ToString());
        player.myStats.clicks = int.Parse(click.clicks.ToString());

        var i = 0;
        foreach(UpgradeManager el in upgradeManagers) 
        {
            player.myStats.state[i] = new Block("UpgradeManager",el.upgradeName, el.cost, el.count,el.inicialCost);
            //Debug.Log($"#{i}, #{el.name}, #{el.cost}, ${el.count}");
            i++;
        }
        foreach(UpgradePerSec el in upgradePerSecs) 
        {
            player.myStats.state[i] = new Block("UpgradePerSec",el.upgradeName, el.cost, el.count,el.inicialCost);
            //Debug.Log($"#{i}, #{el.name}, #{el.cost}, ${el.count}");
            i++;
        }
    }
}
