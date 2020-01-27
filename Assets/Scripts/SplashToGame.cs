using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToGame : MonoBehaviour
{

    public bool companyIsNamed = false;
    void Start()
    {
        StartCoroutine(ToGame());     
    }

    IEnumerator ToGame()
    {
        yield return new WaitForSeconds(4f);
        if (companyIsNamed == false)
        {
            SceneManager.LoadScene("CompanyName");
            companyIsNamed = true;
        } else 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
