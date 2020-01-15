using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    public float money;
    public int moneyPerClick;
    public int moneyPerSec;
    public int clicks;

    public Block[] state = new Block[12];

}
