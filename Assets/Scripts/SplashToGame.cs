using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToGame : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ToGame());     
    }

    IEnumerator ToGame()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
