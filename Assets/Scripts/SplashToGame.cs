using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToGame : MonoBehaviour
{

    public int companyIsNamed;
    void Start()
    {
        StartCoroutine(ToGame());     
    }

    IEnumerator ToGame()
    {
        yield return new WaitForSeconds(4f);
        if (PlayerPrefs.GetInt ("CompanyNamed") != 1)
        {
            PlayerPrefs.SetInt ("CompanyNamed", 1);
            SceneManager.LoadScene("CompanyName");
        } else 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
