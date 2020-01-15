using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //Variaveis globais
    public GameObject achNote;
    public AudioSource achSound;
    public GameObject achTitle;
    public GameObject achDesc;
    public bool achActive = false;

    //Conquista 01
    public GameObject ach01Image;
    public static int ach01Count;
    public int ach01Trigger = 100;
    public int ach01Code;

    //Conquista 02
    public GameObject ach02Image;
    public static int ach02Count;
    public int ach02Trigger = 500;
    public int ach02Code;

    //Conquista 03
    public GameObject ach03Image;
    public static int ach03Count;
    public int ach03Trigger = 1000;
    public int ach03Code;

    void Update()
    {
        if (ach01Count == ach01Trigger && ach01Code != 12345)
        {
            StartCoroutine(Trigger01Ach());
        }

        if (ach02Count == ach02Trigger && ach02Code != 12345)
        {
            StartCoroutine(Trigger02Ach());
        }

        if (ach03Count == ach03Trigger && ach03Code != 12345)
        {
            StartCoroutine(Trigger03Ach());
        }
        
    }

    IEnumerator Trigger01Ach()
    {
        achActive = true;
        ach01Code = 12345;
        achSound.Play();
        ach01Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "clicou um bocado!";
        achDesc.GetComponent<Text>().text = "clicou 100 vezes.";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Resetando UI
        achNote.SetActive(false);
        ach01Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger02Ach()
    {
        achActive = true;
        ach02Code = 12345;
        achSound.Play();
        ach02Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "Clicou bastante!";
        achDesc.GetComponent<Text>().text = "clicou 500 vezes, clicando cada vez mais!!";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Resetando UI
        achNote.SetActive(false);
        ach02Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger03Ach()
    {
        achActive = true;
        ach03Code = 12345;
        achSound.Play();
        ach03Image.SetActive(true);
        achTitle.GetComponent<Text>().text = "CLICOU PRA CARA*&#";
        achDesc.GetComponent<Text>().text = "clicou 1000, PUT* MERD* CLICOU MUITO!!!!!";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //Resetando UI
        achNote.SetActive(false);
        ach03Image.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDesc.GetComponent<Text>().text = "";
        achActive = false;
    }
}
