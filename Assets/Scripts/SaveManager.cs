using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;

public class SaveManager : MonoBehaviour
{

    private Player _player;


    public void Awake()
    {
        _player = GameObject.FindObjectOfType<Player>();
        Load();
    }

    public void Save()
    {

        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.OpenOrCreate);

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(file, _player.myStats);

            Debug.Log("Foi!!!!!!!!!!!!");
        }
        catch (SerializationException e)
        {
            Debug.LogError("Erro:" + e.Message);
        }
        finally
        {
            file.Close();
        }
    }

    public void Load()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/Player.dat", FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            _player.myStats = (Stats)formatter.Deserialize(file);
            Debug.Log($"Carregou {_player.myStats.state.Length}");
            this.MapToUI(_player.myStats);
        }
        catch (SerializationException e)
        {
            Debug.LogError("Erro D:" + e.Message);
        }
        finally
        {
            file.Close();
        }
    }

    public void MapToUI(Stats stats)
    {
        Click click = GameObject.FindObjectOfType<Click>();
        AutoMoneySec moneyPerSec = GameObject.FindObjectOfType<AutoMoneySec>();

        foreach (var item in stats.state)
        {
            click.totalMoney = stats.totalMoney;
            click.money = stats.money;
            click.moneyPerSec = stats.moneyPerSec;
            click.moneyPerClick = stats.moneyPerClick;
            click.clicks = stats.clicks;
            
            switch (item.type)
            {
                case "UpgradeManager":
                    this.mapUpgradeManager(item); 
                break;
                case "UpgradePerSec":
                    this.mapUpgradePerSec(item); 
                break;
            }
        }
    }

    private void mapUpgradeManager(Block item)
    {
        UpgradeManager[] upgradeManagers = GameObject.FindObjectsOfType<UpgradeManager>();
        foreach (var obj in upgradeManagers)
        {
            if(obj.upgradeName == item.id)
            {
                obj.cost = item.cost;
                obj.count = item.count;
            }
        }
    }

    private void mapUpgradePerSec(Block item)
    {
        UpgradePerSec[] upgradePerSecs = GameObject.FindObjectsOfType<UpgradePerSec>();
        foreach (var obj in upgradePerSecs)
        {
            if(obj.upgradeName == item.id)
            {
                obj.cost = item.cost;
                obj.count = item.count;
            }
        }
    }
    void OnApplicationPause()
    {
        Save();
    }
}
