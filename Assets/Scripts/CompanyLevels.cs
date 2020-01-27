using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompanyLevels : MonoBehaviour
{
    public GameObject companyButton1;
    public GameObject companyButton2;
    public GameObject companyButton3;
    public GameObject companyButton4;
    public GameObject companyButton5;

    public Click click;

    void Update()
    {
        if (click.totalMoney >= 0)
        {
            buttonCompany1();
        }
        
        if (click.totalMoney >= 10000)
        {
            buttonCompany2();
        }
        
        if (click.totalMoney >= 50000)
        {
            buttonCompany3();
        }
        
        if (click.totalMoney >= 100000)
        {
            buttonCompany4();
        }
        
        if (click.totalMoney >= 500000)
        {
            buttonCompany5();
        }
    }

    void buttonCompany1()
    {
        companyButton1.SetActive(true);
        companyButton2.SetActive(false);
        companyButton3.SetActive(false);
        companyButton4.SetActive(false);
        companyButton5.SetActive(false);
    }

    void buttonCompany2()
    {
        companyButton2.SetActive(true);
        companyButton1.SetActive(false);
        companyButton3.SetActive(false);
        companyButton4.SetActive(false);
        companyButton5.SetActive(false);
    }

    void buttonCompany3()
    {
        companyButton3.SetActive(true);
        companyButton1.SetActive(false);
        companyButton2.SetActive(false);
        companyButton4.SetActive(false);
        companyButton5.SetActive(false);
    }

    void buttonCompany4()
    {
        companyButton4.SetActive(true);
        companyButton1.SetActive(false);
        companyButton2.SetActive(false);
        companyButton3.SetActive(false);
        companyButton5.SetActive(false);
    }

    void buttonCompany5()
    {
        companyButton5.SetActive(true);
        companyButton1.SetActive(false);
        companyButton2.SetActive(false);
        companyButton3.SetActive(false);
        companyButton4.SetActive(false);
    }
}
